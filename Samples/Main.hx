import pmatch.P;

import haxe.macro.Expr;

@:nativegen class Main {
    static function main () {

        var e = macro {
            var x = 10;
            x;
        }

        P.match (switch e {
            case {expr:EBlock (
                {expr: EVars (_)}...{expr: EConst (CIdent (s))}...l)}:
                    trace ("Is: " + s);
        });

        var x = [[0,1], [2], [3,4]];
        function walk (list:Iterator<Iterable<Int>>) return P.match (switch list {
            case (a...b...ilist)...l: trace (Std.format ("($a,$b)")); walk (l);
            case _...l: walk (l);
            case []: trace ("Done");
        });
        walk (x.iterator ());
    }
}

enum Color {
    Red (val:Array<Int>);
    SubColor (c:Color, x:Int);
    Orange;
}