import pmatch.P;

@:nativegen class Main {
    static function main () {
        trace ("\n\n");
        var x:Array<Array<Dynamic>> = [[0,1,2,6],[2],[4,5]];
        function walk (list:Iterator<Iterable<Int>>) return P.match (switch list {
            case (a...b...r)...l: trace (Std.format ("($a,$b)")); walk (l);
            case _...l: walk (l);
            case []: trace ("Done");
        });
        walk (x.iterator ());

        trace ("\n\n\n\n");
    }
}

enum Color {
    Red (val:Array<Int>);
    SubColor (c:Color, x:Int);
    Orange;
}