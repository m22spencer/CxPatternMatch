
namespace haxe.lang
{
	public  class FieldLookup : haxe.lang.HxObject 
	{
		public    FieldLookup() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static  Array<int> fieldIds = new Array<int>(new int[]{-1052044558, -1044071499, -1010803711, -989319218, -977287912, -974832477, -967766575, -966446102, -958307488, -958305258, -958157168, -958005545, -957756900, -957708287, -957411466, -957411460, -957408577, -957161254, -955850252, -954371938, -944960938, -944563106, -944219033, -942667500, -933872051, -933531251, -922581773, -921324419, -919427207, -899608102, -899463985, -880741719, -877681631, -876938083, -866637986, -864540469, -855401246, -830134618, -822977931, -817475156, -816004332, -804241570, -794696976, -768865525, -749018974, -738205487, -715663947, -710661091, -684263855, -661658032, -639304310, -614773301, -608798114, -599944541, -593948137, -590516445, -571812266, -565080051, -564346026, -557200696, -542285223, -526659619, -526062871, -524334903, -498902297, -491161030, -427038260, -415675517, -415673948, -402670468, -378866319, -372891252, -349611887, -342610131, -310707386, -308859100, -307684791, -290568178, -287380941, -270910835, -259302361, -256786860, -243255484, -232070794, -231474046, -225958497, -217376043, -215416161, -214690691, -212222570, -209020628, -204972399, -198488354, -165510691, -146623634, -143455867, -134549449, -122428535, -103825289, -95344882, -92776181, -64820094, -62241970, -33775209, -20462510, -9058341, 98, 104, 113, 21746, 3447682, 3447690, 4100401, 4745537, 4846113, 5144726, 5193562, 5194459, 5442204, 5442212, 5443986, 5594513, 5594516, 5741474, 5790298, 9342585, 9671866, 10319920, 14532012, 24046298, 29186462, 54824713, 57219237, 57476627, 75105523, 76061764, 87367608, 89897469, 97003981, 109625238, 116192081, 118272011, 152199057, 161311390, 173105980, 194531701, 207609411, 216784640, 247987640, 251772194, 275488739, 277399695, 294683899, 302979532, 315870233, 328878574, 337182705, 344973229, 353096953, 359333139, 362355383, 371166853, 382593693, 389826668, 396115111, 407283053, 422413283, 436924209, 437335495, 441601765, 452737314, 501039929, 502018172, 520590566, 520665567, 549076302, 563324021, 583476134, 589796196, 624614284, 630156697, 669167988, 674203586, 681291596, 710994485, 724060212, 733906088, 738875294, 740007601, 746655852, 753124743, 768686020, 769081627, 769382902, 769706911, 779776921, 780568129, 787326757, 794214425, 794222612, 819292328, 844450169, 845179051, 878910545, 881511967, 881660941, 881661390, 881662505, 881663172, 891161102, 894756598, 905457996, 930445673, 930851917, 935178491, 937216258, 946097238, 946786476, 955433832, 956117047, 962441889, 993363149, 1010514605, 1041537810, 1058973329, 1067353468, 1071652316, 1072885311});
		
		public static  Array<object> fields = new Array<object>(new object[]{"isEOF", "copy", "fold", "hash", "iter", "TDStructure", "OpMult", "join", "OpAdd", "OpAnd", "OpDiv", "OpGte", "OpLte", "OpMod", "OpShl", "OpShr", "OpSub", "OpXor", "keys", "TParent", "last", "list", "lpad", "concat", "mapi", "clear", "next", "EFunction", "enumConstructor", "push", "count", "OpUShr", "rpad", "CType", "sort", "quicksort", "trim", "createEmptyInstance", "wait", "EUntyped", "EArray", "OpNotEq", "spliceVoid", "getProperty", "getEnumName", "TPExpr", "createEnumIndex", "createEnum", "typeof", "OpAssign", "foreach", "concatNative", "endsWith", "className", "setProperty", "EBinop", "TPType", "resolveEnum", "ETernary", "EBlock", "CFloat", "__unsafe_get", "__unsafe_set", "indexOf", "fileName", "EBreak", "EContinue", "ECall", "ECast", "constructs", "allEnums", "OpBoolAnd", "TDEnum", "getClassName", "params", "getInstanceFields", "isObject", "OpBoolOr", "TObject", "empty", "getNativeType", "rtrim", "TClass", "__get", "__set", "EType", "EReturn", "EUnop", "EDisplay", "TUnknown", "EWhile", "EVars", "EConst", "lineNumber", "EObjectDecl", "toNativeReadOnlyArray", "modulus", "unshift", "startsWith", "Orange", "enumParameters", "shift", "ltrim", "addChar", "slice", "getClassFields", "b", "h", "q", "as", "EIf", "EIn", "Red", "__a", "add", "get", "has", "hex", "map", "max", "min", "pop", "pos", "set", "tag", "fields", "field", "first", "resolveClass", "split", "EArrayDecl", "FProp", "compare", "getEnumConstructs", "getSuperClass", "remove", "filter", "urlDecode", "enumEq", "makeVarArgs", "target", "describe", "OpAssignOp", "TBool", "fastCodeAt", "TEnum", "isEmpty", "hasField", "setField", "isFunction", "EDisplayNew", "deleteField", "TNull", "methodName", "TPath", "iterator", "nativeType", "CIdent", "doHash", "lastIndexOf", "getEnum", "trace", "ECheckType", "CRegexp", "findHash", "hasNext", "SubColor", "substr", "message", "urlEncode", "reverse", "insert", "isSpace", "length", "addSub", "TExtend", "alloc", "OpInterval", "getTag", "TFunction", "array", "CString", "getClass", "htmlEscape", "EField", "replace", "TFloat", "fieldIds", "createInstance", "CInt", "EMacro", "EFor", "ENew", "ETry", "valuesArr", "FFun", "FVar", "htmlUnescape", "ESwitch", "TOptional", "TDClass", "TAnonymous", "quotient", "enumIndex", "callMethod", "OpEq", "OpGt", "OpLt", "OpOr", "ofNative", "charCodeAt", "toNativeType", "charAt", "compareMethods", "TInt", "Trim", "toLowerCase", "toString", "lookupHash", "toUpperCase", "EThrow", "keysArr", "fromCharCode", "index", "EParenthesis", "splice", "exists", "equals"});
		
		public static   int doHash(string s)
		{
			unchecked 
			{
				int acc = 0;
				{
					int _g1 = 0;
					int _g = s.Length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						acc = ( ( ( 223 * (( acc >> 1 )) ) + haxe.lang.StringExt.charCodeAt(s, i).@value ) << 1 );
					}
					
				}
				
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
		}
		
		
		public static   string lookupHash(int key)
		{
			unchecked 
			{
				Array<int> ids = haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = ids.length;
				while (( min < max ))
				{
					int mid = ( min + ( (( max - min )) / 2 ) );
					int imid = ids[mid];
					if (( key < imid )) 
					{
						max = mid;
					}
					 else 
					{
						if (( key > imid )) 
						{
							min = ( mid + 1 );
						}
						 else 
						{
							return (( haxe.lang.FieldLookup.fields[mid] + "" ));
						}
						
					}
					
				}
				
				throw haxe.lang.HaxeException.wrap(( "Field not found for hash " + key ));
			}
		}
		
		
		public static   int hash(string s)
		{
			unchecked 
			{
				if (string.Equals(s, default(string))) 
				{
					return 0;
				}
				
				int key = default(int);
				{
					int acc = 0;
					{
						int _g1 = 0;
						int _g = s.Length;
						while (( _g1 < _g ))
						{
							int i = _g1++;
							acc = ( ( ( 223 * (( acc >> 1 )) ) + haxe.lang.StringExt.charCodeAt(s, i).@value ) << 1 );
						}
						
					}
					
					key = ((int) (( ((uint) (acc) ) >> 1 )) );
				}
				
				Array<int> ids = haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = ids.length;
				while (( min < max ))
				{
					int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
					int imid = ids[mid];
					if (( key < imid )) 
					{
						max = mid;
					}
					 else 
					{
						if (( key > imid )) 
						{
							min = ( mid + 1 );
						}
						 else 
						{
							string field = (( haxe.lang.FieldLookup.fields[mid] + "" ));
							if (( ! (haxe.lang.Runtime.eq(field, s)) )) 
							{
								return  ~ (key) ;
							}
							
							return key;
						}
						
					}
					
				}
				
				ids.insert(min, key);
				haxe.lang.FieldLookup.fields.insert(min, s);
				return key;
			}
		}
		
		
		public static   int findHash(int hash, Array<int> hashs)
		{
			unchecked 
			{
				int min = 0;
				int max = hashs.length;
				while (( min < max ))
				{
					int mid = ( (( max + min )) / 2 );
					int imid = hashs[mid];
					if (( hash < imid )) 
					{
						max = mid;
					}
					 else 
					{
						if (( hash > imid )) 
						{
							min = ( mid + 1 );
						}
						 else 
						{
							return mid;
						}
						
					}
					
				}
				
				return  ~ (min) ;
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.lang.FieldLookup.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.FieldLookup.__hx_class) : (haxe.lang.FieldLookup.__hx_class = new haxe.lang.Class(new haxe.lang.FieldLookup(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    FieldLookup(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, bool isStatic, object @value)
		{
			unchecked 
			{
				if (isStatic) 
				{
					switch (hash)
					{
						case 9342585:
						{
							return haxe.lang.FieldLookup.fields = ((Array<object>) (((Array) (@value) ).cast<object>()) );
						}
						
						
						case 738875294:
						{
							return haxe.lang.FieldLookup.fieldIds = ((Array<int>) (((Array) (@value) ).cast<int>()) );
						}
						
						
						default:
						{
							return this.__hx_lookupSetField(field, hash, @value);
						}
						
					}
					
				}
				 else 
				{
					switch (hash)
					{
						default:
						{
							return base.__hx_setField(field, hash, isStatic, @value);
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool isStatic, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				if (isStatic) 
				{
					switch (hash)
					{
						case 396115111:
						{
							return new haxe.lang.Closure("findHash", 396115111, ((haxe.lang.IHxObject) (haxe.lang.FieldLookup.__hx_getClassStatic()) ));
						}
						
						
						case 1158164430:
						{
							return new haxe.lang.Closure("hash", 1158164430, ((haxe.lang.IHxObject) (haxe.lang.FieldLookup.__hx_getClassStatic()) ));
						}
						
						
						case 955433832:
						{
							return new haxe.lang.Closure("lookupHash", 955433832, ((haxe.lang.IHxObject) (haxe.lang.FieldLookup.__hx_getClassStatic()) ));
						}
						
						
						case 353096953:
						{
							return new haxe.lang.Closure("doHash", 353096953, ((haxe.lang.IHxObject) (haxe.lang.FieldLookup.__hx_getClassStatic()) ));
						}
						
						
						case 9342585:
						{
							return haxe.lang.FieldLookup.fields;
						}
						
						
						case 738875294:
						{
							return haxe.lang.FieldLookup.fieldIds;
						}
						
						
						default:
						{
							return this.__hx_lookupField(field, hash, throwErrors, isCheck);
						}
						
					}
					
				}
				 else 
				{
					switch (hash)
					{
						default:
						{
							return base.__hx_getField(field, hash, isStatic, throwErrors, isCheck);
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, bool isStatic, Array dynargs)
		{
			unchecked 
			{
				if (isStatic) 
				{
					switch (hash)
					{
						case 396115111:
						{
							return haxe.lang.FieldLookup.findHash(haxe.lang.Runtime.toInt(dynargs[0]), ((Array<int>) (((Array) (dynargs[1]) ).cast<int>()) ));
						}
						
						
						case 1158164430:
						{
							return haxe.lang.FieldLookup.hash((( dynargs[0] + "" )));
						}
						
						
						case 955433832:
						{
							return haxe.lang.FieldLookup.lookupHash(haxe.lang.Runtime.toInt(dynargs[0]));
						}
						
						
						case 353096953:
						{
							return haxe.lang.FieldLookup.doHash((( dynargs[0] + "" )));
						}
						
						
						default:
						{
							return ((haxe.lang.Function) (this.__hx_getField(field, hash, true, true, false)) ).__hx_invokeDynamic(dynargs);
						}
						
					}
					
				}
				 else 
				{
					switch (hash)
					{
						default:
						{
							return base.__hx_invokeField(field, hash, isStatic, dynargs);
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_classFields(Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("findHash");
				baseArr.push("hash");
				baseArr.push("lookupHash");
				baseArr.push("doHash");
				baseArr.push("fields");
				baseArr.push("fieldIds");
			}
		}
		
		
		public override   void __hx_getFields(Array<object> baseArr, bool isInstanceFields)
		{
			unchecked 
			{
				if (isInstanceFields) 
				{
					{
					}
					
				}
				 else 
				{
					base.__hx_getFields(baseArr, isInstanceFields);
				}
				
			}
		}
		
		
		public override   haxe.lang.Class __hx_getClass()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.lang.FieldLookup.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.FieldLookup.__hx_class) : (haxe.lang.FieldLookup.__hx_class = new haxe.lang.Class(new haxe.lang.FieldLookup(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.FieldLookup(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.FieldLookup();
			}
		}
		
		
	}
}


