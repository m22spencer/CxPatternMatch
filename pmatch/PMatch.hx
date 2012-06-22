package pmatch;

import haxe.macro.Expr;
import haxe.macro.Context;

using Lambda;

class PMatch {
    #if macro
    var locals:Int;
    public function new () {
        locals = 0;
    }

    function make (e:ExprDef):Expr {
        return {expr:e, pos:Context.currentPos ()};
    }

    function local ():Expr {
        return make (EConst (CIdent ("__pm"+locals++)));
    }
    





    static function doCases (value:Expr, values:Array<Expr>, expr:Expr) {
        var cases:Array<Expr> = [];
        var allScopedVals = null;
        
        for (val in values) {
            var ctx = new PCtx ();
            var ast = CaseMatch.caseMatch (value, val, macro matched=true, ctx);

            if (allScopedVals == null) {
                allScopedVals = new List ();
                allScopedVals = ctx.scopedVals;
            } else {
                var union = ctx.scopedVals.filter (function (n) return allScopedVals.exists (function (nn) return nn==n));
                if (union.count () != allScopedVals.count ()) {
                    throw new Error ("Must have matching local scope vars", Context.currentPos ());
                }
            }

            cases.push (macro if (!matched) {
                $ast;
            });
        }

        var exprs = [];
        for (val in allScopedVals) {
            exprs.push (
                {expr:EVars ([{name:val, type:null, expr:macro cast null}]), pos:Context.currentPos ()});
        }
        exprs = exprs.concat (cases);
        exprs.push (macro 
            if (matched) {
                $expr;
            });

        var block = {expr:EBlock (exprs), pos:Context.currentPos ()};

        return macro if (!matched) $block;


    }

    #end

    @:macro public static function test (e:Expr):Expr {
        var m = switch e.expr {
            case ESwitch (e, cases, edef):
                var ast = doCases (e, cases[0].values, cases[0].expr);
                var cexprs = [];
                for (c in cases) {
                    var ast = doCases (e, c.values, c.expr);
                    cexprs.push (ast);
                }
                var cblock = {expr:EBlock (cexprs), pos:Context.currentPos ()};
                macro {
                    var matched = false;
                    $cblock;
                }
            default: 
                throw new Error ("Pattern matching requires you to pass in a switch statement", Context.currentPos ());
                macro null;

        }
        return m;
    }
}

class CaseMatch {
    #if macro
    public static function caseMatch (value:Expr, caseCheck:Expr, inner:Expr, context:PCtx) {
        return proc (value, caseCheck, inner, context);
    }

    static function proc (value:Expr, pattern:Expr, inner:Expr, context:PCtx):Expr {
        var m = macro null;
        switch pattern.expr {
            case EConst (c): switch c {
                case CInt (s), CFloat (s), CString (s):
                    m= macro if ($value == $pattern) $inner;
                case CIdent (s): switch s {
                        case "_": m = inner;
                        default: 
                            context.scopedVals.add (s);
                            m = macro {
                                $pattern = $value;          //Extract to scoped vals
                                $inner;
                            }
                    }
                case CRegexp (r, opt): m = macro if ($pattern.match ($value)) $inner;
                default:
            }
            case ECall (c,args):                            //Enum handling
                var tfun = Context.typeof (c);
                switch tfun {
                    case TFun (_, ret):
                        switch ret {
                            case TEnum (t, params):
                                var out_args = [];
                                var inject:Expr = macro (null);
                                m = inject;
                                for (arg in args) {
                                    var temp_local = local ();
                                    inner = proc (temp_local, arg, inner, context);
                                    out_args.push (temp_local);
                                }
                                var out_pattern = {expr:ECall (c, out_args), pos:Context.currentPos ()};

                                inject.expr = (macro switch $value {
                                    case $out_pattern: $inner; 
                                    default:
                                }).expr;

                            default:
                        }
                    default:
                }
            case EObjectDecl (efields):                     //Structure checking
                var inject = macro (null);
                m = inject;
                for (field in efields) {
                    var temp_local = local ();
                    var expr_fld = {expr:EConst (CString (field.field)), pos:Context.currentPos ()};
                    var expr_vars = {expr:EVars ([{name:ident(temp_local), type:null, expr: macro Reflect.field ($value, $expr_fld)}]), pos:Context.currentPos ()};

                    inner = proc (temp_local, field.expr, inner, context);
                    m = macro if (Reflect.hasField ($value, $expr_fld)) {
                        $expr_vars;
                        $m;
                    }
                }
                inject.expr = inner.expr;
            case EArrayDecl (values):
                switch (values.length) {
                    case 0: 
                        var iterator = macro $value.iterator ();
                        m = macro if ($iterator.hasNext () == false) $inner;
                    default:
                }
            default:
        }
        return m;
    }

    static function local ():Expr {
        return {expr:EConst (CIdent ("__pm" + Std.int (Math.random () * 10000))), pos:Context.currentPos ()};
    }

    static function ident (e:Expr) {
        return switch e.expr {
            case EConst (c): switch c {
                case CIdent (s): s;
                default: "";
            }
            default: "";
        }
    }
    static function mk (def:ExprDef) {
        return {expr:ExprDef, }
    }

    static function getIterator (e:Expr) {
        return switch Context.typeof (e) {
            case TType (t, ar):
                var is = t.get ();
                if (is.name == "Iterator" && is.pack.length == 0) 
                    e;
                else
                    macro $e.iterator ();
            default: macro $e.iterator ();
        }
    }
    #end
}

class PCtx {
    public function new () {
        scopedVals = new List ();
    }

    public var scopedVals:List<String>;
}



/**

    case 
        EBinop (_, _, EConst (CIdent (s)))
        EConst (CIdent (s)):
            trace (s);

Becomes:
    var matched = false;
    if (!matched) {                                         //Begin case
        var s:String = cast null;                           //push all shared extractions to outer scope
        if (!matched) {                                     //Technically a NOP
            switch value {
                case EBinop (__pm1,__pm2, __pm3):
                    switch __pm3 {
                        case EConst (__pm4):
                            switch __pm4 {
                                case CIdent (__pm5):
                                    s = __pm5;
                                    matched = true;         //Matched and set outer scope
                                default:
                            }
                        default:
                    }
                default:
            }
        }
        if (!matched) {                                     //If first check failed
            switch value {
                case EConst (__pm6):
                    switch __pm6 {
                        case Cident (__pm7):
                            s = __pm7;
                            matched = true;                 //Matched and set outer scope
                        default:
                    }
                default:
            }
        }
        if (matched) {
            trace (s);                                      //If matched worked, we will now execute this particular code block
        }
    }
**/