package pmatch;

import haxe.macro.Tools;
import haxe.macro.Compiler;
import haxe.macro.Expr;
import haxe.macro.Context;

class PMatchGen {
    #if macro
    /**
     * This function takes an Expr and will properly delegate it to the correct expression parser which will recursively call this
     * 
     * 
     */


    /**
     * This will start a check for "case"
     */
    static function genWithInner (value:Expr, pattern:Expr, inner:Expr):Expr {
        var m = macro null;

        //trace ("gen with inner");


        switch pattern.expr {
            case EConst (c):
                switch c {
                    case CInt (s), CFloat (s), CString (s):
                        m = macro if ($value == $pattern) $inner;
                    case CIdent (s):
                        switch s {
                            case "_": m = inner;
                            default: 
                                tryEnum (pattern);
                        }
                    case CRegexp (r, opt):
                        m = macro if ($pattern.match ($value)) $inner;
                    default:
                }
            case EObjectDecl (efields):
                var inject:Expr = macro (null);
                m = inject;
                for (efield in efields) {
                    var field = efield.field;
                    var expr = efield.expr;

                    var lv_name = "pm" + Std.int (Math.random () * 10000);

                    var expr_fld = mk (EConst (CString (field)));
                    var expr_vars = mk (EVars ([{name:lv_name, type:null, expr:macro Reflect.field ($value, $expr_fld)}]));
                    var expr_local = mk (EConst (CIdent (lv_name)));

                    inner = genWithInner (expr_local, expr, inner);

                    m = macro if (Reflect.hasField ($value, $expr_fld)) {
                        $expr_vars;
                        $m;
                    };
                }
                inject.expr = inner.expr;
            case ECall (c, args):
                var tfun = Context.typeof (c);
                switch tfun {
                    case TFun (_, ret):
                        switch ret {
                            case TEnum (t, params):
                                var enum_name = switch c.expr {
                                    case EConst (const):
                                        switch const {
                                            case CIdent (s): s;
                                            default: "";
                                        }
                                    default: "";
                                }
                                //trace ("Found enum: " + enum_name);
                                //begin processing enum

                                var out_args = [];

                                var inject:Expr = macro (null);
                                m = inject;
                                for (arg in args) {
                                    //trace ("Arg: " + arg);
                                    var temp_var = switch arg.expr {
                                        case EConst (c):
                                            switch c {
                                                case CIdent (s): arg;
                                                default: tv ();
                                            }
                                        default: tv ();
                                    }

                                    inner = genWithInner (temp_var, arg, inner);

                                    out_args.push (temp_var);
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
            case EArrayDecl (values):
                switch values.length {
                    case 0: 
                        var iterator = getIterator (value);
                        m = macro if ($iterator.hasNext () == false) $inner;
                }

            case EBinop (op, e1, e2):
                

                var inject = macro (null);
                m = inject;

                for (l in lst) {
                    var lv_name = switch l.expr {
                        case EConst (c): switch c {
                            case CIdent (s): s;
                            default: "pm" + Std.int (Math.random () * 10000);
                        }
                        default: "pm" + Std.int (Math.random () * 10000);
                    }

                    var expr_vars = mk (EVars ([{name:lv_name, type:null, expr:macro __iter.next ()}]));
                    var expr_blank = mk (EVars ([{name:lv_name, type:null, expr:macro cast null}]));

                    gdecl.push (expr_blank);


                    var lv_name_expr = {expr:EConst (CIdent (lv_name)), pos:Context.currentPos ()};

                    if (lv_name.indexOf ("pm") != -1) {
                        inner = genWithInner (lv_name_expr, l, inner);
                    }

                    m = macro if ($lstvar.hasNext ()) {
                        //$expr_vars;
                        $lv_name_expr = $lstvar.next ();
                        $m;
                    };
                }

                var lst_nm = switch lstvar.expr {
                        case EConst (c): switch c {
                            case CIdent (s): s;
                            default: "";
                        }
                        default: "";
                    }

                var expr_lst_var = mk (EVars ([{name:lst_nm, type:null, expr: macro __iter}]));
                var expr_lst_blank = mk (EVars ([{name:lst_nm, type:null, expr:macro cast null}]));

                gdecl.push (expr_lst_blank);

                var iterator = getIterator (value);

                m = macro {
                    $lstvar = Reflect.copy ($iterator);
                    //$expr_lst_var;
                    $m;
                };

                inject.expr = inner.expr;



            default: trace ("Unhandled: " + pattern);
        }

        return m;
    }

    /*
        This will fail when resolving deeper types, since they are not yet resolved here, 
                                               and have not typing information associated

    */
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

    static function tryEnum (e:Expr) {
        switch Context.typeof (e) {
            case TEnum (t, args):
                trace ("Found enum: " + Context.typeof (e));
            default:
        }
    }

    static function mk (def:ExprDef):Expr {
        return {expr:def, pos:Context.currentPos ()};
    }


    static function tv ():Expr {
        return {expr:EConst (CIdent ("pm"+Std.int (Math.random () * 0xFFFF))), pos:Context.currentPos ()};
    }

    #end


    /**
     *  This generates the typematchign boilerplate
     */
    @:macro public static function patternMatch (switchStatement:Expr):Expr {
        var exprs = [];

        gdecl = [];

        switch switchStatement.expr {
            case ESwitch (equery, ecases, edef):
                for (c in ecases) {
                    var ccheck = genWithInner (equery, c.values[0], macro foundMatch = true);

                    var idx = mk (EConst (CInt (exprs.length+"")));
                    c.values = [idx];

                    var e = macro if (!foundMatch) {
                        $ccheck;
                        if (foundMatch) matched = $idx;
                    };

                    exprs.push (e);
                }

            default:
        }

        var eblock = {expr:EBlock (exprs), pos:Context.currentPos ()};


        var final = switch (switchStatement.expr) {
            case ESwitch (equery, ecases, edef):
                mk (ESwitch (macro matched, ecases, edef));
            default: macro null;
        }

        var fullblock = macro {
            var foundMatch = false;
            var matched:Int = -1;
            $eblock;

            $final;
        }

        switch fullblock.expr {
            case EBlock (exprs): 
                fullblock.expr = EBlock (gdecl.concat (exprs));
            default:
        }

        ///*
        return fullblock;
        /*/
        tink.macro.tools.Printer.print (fullblock);

        return macro null;
        //*/
    }

    static var gdecl:Array<Expr>;
}