CxPatternMatch
==============

Experimental pattern matching extension for Haxe

Why
---
    I'm very very excited about the pattern matching support coming in 3.0, and can't wait for summer to try it out.
    Also, testing to see how verbose it can become while adhering to somewhat haxe-ish syntax.



IMPORTANT
---------
    * Requires Haxe r4888 (2.10)
    * EXTREMELY BUGGY! This is a prototype.




Usage
-----
    P.match (switch value {
        case PATTERN: //do stuff
    });



Basics
------
    * _ represents "Any value". It is not stored for local scope usage.
    * x represents any value, but is stored for local scope usage. (eg: myVal, x, y, any variable name)
    * "MyString", 3.0, 10 will match exactly, and are not store for local scope usage
    * ~/MySt[A-Za-z]*/ will do a regex match on the field. 



Enum matching
-------------
    * Enum will recursively match (as will anything else)
        switch EConst (CIdent ("x")) {
            case EConst (CIdent (_)): trace ("I found a CIDent!");
            case _: trace ("Something else..."));
        }



Structure matching
------------------
    switch new flash.geom.Point () {
        case {x:xVal}: trace ("This structure contains x with val of -> " + xVal);
    }



Iterable matching
-----------------
    * [] represents an empty set
    * a...list   a = head  list = tail:Iterable<T>;
        can be chained:  a...b...list
        can be nested: (a...b...ilist)...c...list
        can be directly matched:  10...list
    * [a,b,c]  exact iterator match. Will only match if contains the proper number of passing elements




Example
=======

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
