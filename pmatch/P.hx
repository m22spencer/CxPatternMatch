package pmatch;

import haxe.macro.Context;
import haxe.macro.Expr;

using Lambda;

class P {
    @:macro public static function match (e:Expr):Expr {
        var m = switch e.expr {
            case ESwitch (e, cases, edef):
                var cexprs = [];
                for (c in cases) {
                    var cm = new CaseMatch ();
                    var ast = cm.execute (e, c.values[0], macro matched = true);
                    var expr = c.expr;

                    var eexprs = [];

                    for (name in cm.exposedvars.keys ()) {
                        var temp_var = {expr:EVars ([{name:name, type:null, expr: macro cast null}]), pos:Context.currentPos ()};
                        eexprs.push (temp_var);
                    }
                    eexprs.push (ast);
                    eexprs.push (macro if (matched) __ret = cast $expr);

                    var eblock = {expr:EBlock (eexprs), pos:Context.currentPos ()};

                    cexprs.push (macro if (!matched) {
                        $eblock;
                    });
                }
                var cblock = {expr:EBlock (cexprs), pos:Context.currentPos ()};
                macro {
                    var __ret = cast null; 
                    var matched = false;
                    $cblock;
                    __ret;
                }
                
            default: macro null;
        }
        //trace (m);
        return m;
    }
}


class CaseMatch {
    #if macro
    var injection_point:Expr;
    var base:Expr;

    var typehash:Hash<haxe.macro.Type>;

    public var exposedvars:Hash<haxe.macro.Type>;

    public function new () {
        typehash = new Hash ();
        exposedvars = new Hash ();
    }

    public function execute (value:Expr, _case:Expr, inner:Expr) {
        injection_point = inner;
        base = macro ($injection_point);
        proc (value, _case);
        return switch base.expr {
            case EParenthesis (e): e;
            default: macro null;
        }
    }

    /**
        Immediate AST modification to allow access the typer, even under heavy modification.
    */
    function inject (cb:Expr->Expr) {
        var t = {expr:injection_point.expr, pos:injection_point.pos};
        injection_point.expr = cb (t).expr;
        injection_point = t;
    }

    function local (of:Expr):Expr {
        var id = "__pm" + Std.int (Math.random () * 10000);
        return {expr:EConst (CIdent (id)), pos:of.pos};
    }

    function settype (e:Expr, t:haxe.macro.Type) {
        if (typehash.exists (ident (e))) throw "Cannot set duplicate type";
        typehash.set (ident (e), t);
    }

    function ident (e:Expr) {
        switch e.expr {
            case EConst (c): switch c {
                case CIdent (s): return s;
                default: throw "Invalid ident: " + e;
            }
            default: throw "Invalid ident: " + e;
        }
    }

    //We need to store types manually, since we will be reconstrucing the ast
    function fetchtype (e:Expr):haxe.macro.Type {
        return switch e.expr {
            case EConst (c): switch c {
                case CIdent (s): if (typehash.exists (ident (e))) {
                        cast typehash.get (ident (e));
                    } else {
                        var t = Context.typeof (e);
                        settype (e, t);
                        t;
                    }
                default: Context.typeof (e);
            }
            default: Context.typeof (e);
        }
    }

    function proc (value:Expr, pattern:Expr) {
        switch pattern.expr {
            case EConst (c): switch c {
                case CInt (s), CFloat (s), CString (s):
                    inject (function (inner) return macro if ($value==$pattern) $inner);
                case CRegexp (r, opt): 
                    inject (function (inner) return macro if ($pattern.match ($value)) $inner);
                case CIdent (s):
                    switch s {
                        case "_":
                        default:
                            exposedvars.set (s, fetchtype (value));
                            inject (function (inner) return macro {
                                $pattern = $value;
                                $inner;
                            });
                    }
                default:
            }
            case EObjectDecl (efields):
                var lazy = [];
                for (field in efields) {
                    var temp_local = local (field.expr);
                    var expr_fld = {expr:EConst (CString (field.field)), pos:Context.currentPos ()};
                    var expr_vars = {expr:EVars ([{name:ident(temp_local), type:null, expr: macro Reflect.field ($value, $expr_fld)}]), pos:Context.currentPos ()};

                    inject (function (inner) return macro {
                            var fld = Reflect.field ($value, $expr_fld);
                            if (fld != null) {
                                $expr_vars;
                                $inner;
                            }
                        });
                    lazy.push (function () proc (temp_local, field.expr));
                }
                for (l in lazy) l ();

            case ECall (c,args):                            //Enum handling
                var tfun:haxe.macro.Type = fetchtype (c);
                switch tfun {
                    case TFun (_, ret):
                        switch ret {
                            case TEnum (t, params):
                                var cons = switch t.get ().constructs.get (ident (c)).type {
                                    case TFun (consargs, _): consargs;
                                    default: [];
                                }

                                var lazy:Array<Void->Void> = [];

                                for (i in 0...args.length) {
                                    var arg = args[i];
                                    var temp_local = local (arg);
                                    settype (temp_local, cons[i].t);
                                    lazy.push (function () proc (temp_local, arg));
                                    args[i] = temp_local;
                                }

                                inject (function (inner) return macro 
                                    switch $value {
                                        case $pattern: $inner;
                                        default:
                                    });
                                for (l in lazy) {
                                    l ();
                                }

                            default:
                        }
                    default:
                }
            case EArrayDecl (values):                       //Empty set and iterable match
                switch (values.length) {
                    case 0:
                        var iterator = eIterator (value);
                        inject (function (inner) return macro if ($iterator.hasNext () == false) $inner);
                    default:
                        var iterator = eIterator (value);

                        var temp_iter = {expr:EVars ([{name:"__pmiter", type:null, expr: macro $iterator}]), pos:Context.currentPos ()};
                        inject (function (inner) return macro {
                            $temp_iter;
                            $inner;
                        });

                        var lazy = [];
                        for (v in values) {
                            var temp_local = local (v);
                            settype (temp_local, subType (fetchtype (value))[0]); //FIXME: Dynamic for idents..

                            var temp_decl = {expr:EVars ([{name:ident(temp_local), type:null, expr: macro __pmiter.next ()}]), pos:v.pos};

                            inject (function (inner) return macro 
                                if (__pmiter.hasNext ()) {
                                    $temp_decl;
                                    $inner;
                                });

                            lazy.push (function () proc (temp_local, v));
                        }

                        inject (function (inner) return macro 
                            if (!__pmiter.hasNext ()) $inner);

                        for (l in lazy) l ();
                }
            case EBinop (op, e1, e2):                           //List matching:  | _ :: l ->
                //trace ("binop on value: " + value);
                //trace ("Injection point: " + injection_point);
                var lst = [];
                function doBinOp (e:Expr) {
                    switch e.expr {
                        case EBinop (op, e1, e2):
                            switch op {
                                case OpInterval: 
                                    doBinOp (e1);
                                    doBinOp (e2);
                                default: lst.push (e);
                            }
                        default: lst.push (e);
                    }
                }
                doBinOp (pattern);
                var lstvar = lst.pop ();     //FIXME enforce CIdent

                //l...s...t...lstvar
                var iterator = macro null;
                iterator = eIterator (value);
                //trace ("Iterator: " + iterator + " of " + value);
                //trace (fetchtype (value));

                exposedvars.set (ident (lstvar), fetchtype (value));
                settype (lstvar, fetchtype (value));                                 //iterator
                inject (function (inner) return macro {
                    $lstvar = $iterator;
                    $inner;
                });

                var lazy = [];
                for (l in lst) {
                    var temp_local = local (l);
                    //trace ("tlocal: " + fetchtype (value));
                    //trace ("tlocal: " + temp_local + " -> type: " + subType (fetchtype (value))[0]);
                    //trace ("lstvar: " + fetchtype (lstvar));
                    settype (temp_local, subType (fetchtype (value))[0]);     //FIXME: Dynamic for idents..
                    var temp_decl = {expr:EVars ([{name:ident(temp_local), type:null, expr: macro $lstvar.next ()}]), pos: l.pos};
                    inject (function (inner) return macro
                        if ($lstvar.hasNext ()) {
                            $temp_decl;
                            $inner;
                        });
                    lazy.push (function () proc (temp_local, l));
                }
                //trace ("\n");
                for (l in lazy) l ();
            case EParenthesis (e):
                //trace ("Proc paren: " + value + " -> " + e);
                inject (function (inner) return macro {
                    "Inner Point";
                    $value;
                    $inner;
                });
                //trace ("Has def?" + typehash.exists (ident (value)));

                //trace ("Base: " + tink.macro.tools.Printer.print (base));
                //trace ("Going to proc: " + value);
                proc (value, e);
            default:
        }
    }

    function subType (t:haxe.macro.Type) {
        return switch t {
            case TType (a, b): b;
            case TInst (a, b): b;
            default: null;
        }

    }

    function eIterator (e:Expr, ?posinfos:haxe.PosInfos) {
        var type = fetchtype (e);
        switch type {
            case TInst (a, b):
                var flds = a.get ().fields.get ();
                if (flds.exists (function (fld) return fld.name == "iterator")) 
                    return macro $e.iterator ();
            case TType (a, b):
                switch a.get ().name {
                    case "Iterator": return macro Reflect.copy ($e);
                    case "Iterable": return macro cast $e.iterator ();
                    default:
                }
            default:
        }
        Context.error ("Invalid type for array pattern matching: " + posinfos + " -> " + type, e.pos);
        return null;
    }

    @:macro function declIdent (e:Expr) {
        return e;
    }
    #end
}