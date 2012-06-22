
namespace haxe.macro
{
	public  class Constant : haxe.lang.Enum 
	{
		static Constant() 
		{
			haxe.macro.Constant.constructs = new Array<object>(new object[]{"CInt", "CFloat", "CString", "CIdent", "CRegexp", "CType"});
		}
		public    Constant(int index, Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
				haxe.macro.Constant.__hx_ctor(this, index, @params);
			}
		}
		
		
		public static   void __hx_ctor(haxe.macro.Constant __temp_me20, int index, Array<object> @params)
		{
			unchecked 
			{
				object __temp_expr58 = default(object);
			}
		}
		
		
		public static  Array<object> constructs;
		
		public static   haxe.macro.Constant CInt(string v)
		{
			unchecked 
			{
				return new haxe.macro.Constant(0, new Array<object>(new object[]{v}));
			}
		}
		
		
		public static   haxe.macro.Constant CFloat(string f)
		{
			unchecked 
			{
				return new haxe.macro.Constant(1, new Array<object>(new object[]{f}));
			}
		}
		
		
		public static   haxe.macro.Constant CString(string s)
		{
			unchecked 
			{
				return new haxe.macro.Constant(2, new Array<object>(new object[]{s}));
			}
		}
		
		
		public static   haxe.macro.Constant CIdent(string s)
		{
			unchecked 
			{
				return new haxe.macro.Constant(3, new Array<object>(new object[]{s}));
			}
		}
		
		
		public static   haxe.macro.Constant CRegexp(string r, string opt)
		{
			unchecked 
			{
				return new haxe.macro.Constant(4, new Array<object>(new object[]{r, opt}));
			}
		}
		
		
		public static   haxe.macro.Constant CType(string s)
		{
			unchecked 
			{
				return new haxe.macro.Constant(5, new Array<object>(new object[]{s}));
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.Constant.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.Constant.__hx_class) : (haxe.macro.Constant.__hx_class = new haxe.lang.Class(new haxe.macro.Constant(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    Constant(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
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
						case 1744813180:
						{
							return haxe.macro.Constant.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
						case 1270545565:
						{
							return new haxe.lang.Closure("CType", 1270545565, ((haxe.lang.IHxObject) (haxe.macro.Constant.__hx_getClassStatic()) ));
						}
						
						
						case 389826668:
						{
							return new haxe.lang.Closure("CRegexp", 389826668, ((haxe.lang.IHxObject) (haxe.macro.Constant.__hx_getClassStatic()) ));
						}
						
						
						case 344973229:
						{
							return new haxe.lang.Closure("CIdent", 344973229, ((haxe.lang.IHxObject) (haxe.macro.Constant.__hx_getClassStatic()) ));
						}
						
						
						case 669167988:
						{
							return new haxe.lang.Closure("CString", 669167988, ((haxe.lang.IHxObject) (haxe.macro.Constant.__hx_getClassStatic()) ));
						}
						
						
						case 1605198425:
						{
							return new haxe.lang.Closure("CFloat", 1605198425, ((haxe.lang.IHxObject) (haxe.macro.Constant.__hx_getClassStatic()) ));
						}
						
						
						case 746655852:
						{
							return new haxe.lang.Closure("CInt", 746655852, ((haxe.lang.IHxObject) (haxe.macro.Constant.__hx_getClassStatic()) ));
						}
						
						
						case 1744813180:
						{
							return haxe.macro.Constant.constructs;
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
						case 1270545565:
						{
							return haxe.macro.Constant.CType((( dynargs[0] + "" )));
						}
						
						
						case 389826668:
						{
							return haxe.macro.Constant.CRegexp((( dynargs[0] + "" )), (( dynargs[1] + "" )));
						}
						
						
						case 344973229:
						{
							return haxe.macro.Constant.CIdent((( dynargs[0] + "" )));
						}
						
						
						case 669167988:
						{
							return haxe.macro.Constant.CString((( dynargs[0] + "" )));
						}
						
						
						case 1605198425:
						{
							return haxe.macro.Constant.CFloat((( dynargs[0] + "" )));
						}
						
						
						case 746655852:
						{
							return haxe.macro.Constant.CInt((( dynargs[0] + "" )));
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
				baseArr.push("CType");
				baseArr.push("CRegexp");
				baseArr.push("CIdent");
				baseArr.push("CString");
				baseArr.push("CFloat");
				baseArr.push("CInt");
				baseArr.push("constructs");
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
				return ((haxe.lang.Class) (( (( haxe.macro.Constant.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.Constant.__hx_class) : (haxe.macro.Constant.__hx_class = new haxe.lang.Class(new haxe.macro.Constant(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.Constant(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.Constant(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
	}
}



namespace haxe.macro
{
	public  class Binop : haxe.lang.Enum 
	{
		static Binop() 
		{
			haxe.macro.Binop.constructs = new Array<object>(new object[]{"OpAdd", "OpMult", "OpDiv", "OpSub", "OpAssign", "OpEq", "OpNotEq", "OpGt", "OpGte", "OpLt", "OpLte", "OpAnd", "OpOr", "OpXor", "OpBoolAnd", "OpBoolOr", "OpShl", "OpShr", "OpUShr", "OpMod", "OpAssignOp", "OpInterval"});
			haxe.macro.Binop.OpAdd = new haxe.macro.Binop(0, default(Array<object>));
			haxe.macro.Binop.OpMult = new haxe.macro.Binop(1, default(Array<object>));
			haxe.macro.Binop.OpDiv = new haxe.macro.Binop(2, default(Array<object>));
			haxe.macro.Binop.OpSub = new haxe.macro.Binop(3, default(Array<object>));
			haxe.macro.Binop.OpAssign = new haxe.macro.Binop(4, default(Array<object>));
			haxe.macro.Binop.OpEq = new haxe.macro.Binop(5, default(Array<object>));
			haxe.macro.Binop.OpNotEq = new haxe.macro.Binop(6, default(Array<object>));
			haxe.macro.Binop.OpGt = new haxe.macro.Binop(7, default(Array<object>));
			haxe.macro.Binop.OpGte = new haxe.macro.Binop(8, default(Array<object>));
			haxe.macro.Binop.OpLt = new haxe.macro.Binop(9, default(Array<object>));
			haxe.macro.Binop.OpLte = new haxe.macro.Binop(10, default(Array<object>));
			haxe.macro.Binop.OpAnd = new haxe.macro.Binop(11, default(Array<object>));
			haxe.macro.Binop.OpOr = new haxe.macro.Binop(12, default(Array<object>));
			haxe.macro.Binop.OpXor = new haxe.macro.Binop(13, default(Array<object>));
			haxe.macro.Binop.OpBoolAnd = new haxe.macro.Binop(14, default(Array<object>));
			haxe.macro.Binop.OpBoolOr = new haxe.macro.Binop(15, default(Array<object>));
			haxe.macro.Binop.OpShl = new haxe.macro.Binop(16, default(Array<object>));
			haxe.macro.Binop.OpShr = new haxe.macro.Binop(17, default(Array<object>));
			haxe.macro.Binop.OpUShr = new haxe.macro.Binop(18, default(Array<object>));
			haxe.macro.Binop.OpMod = new haxe.macro.Binop(19, default(Array<object>));
			haxe.macro.Binop.OpInterval = new haxe.macro.Binop(21, default(Array<object>));
		}
		public    Binop(int index, Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
				haxe.macro.Binop.__hx_ctor(this, index, @params);
			}
		}
		
		
		public static   void __hx_ctor(haxe.macro.Binop __temp_me21, int index, Array<object> @params)
		{
			unchecked 
			{
				object __temp_expr59 = default(object);
			}
		}
		
		
		public static  Array<object> constructs;
		
		public static  haxe.macro.Binop OpAdd;
		
		public static  haxe.macro.Binop OpMult;
		
		public static  haxe.macro.Binop OpDiv;
		
		public static  haxe.macro.Binop OpSub;
		
		public static  haxe.macro.Binop OpAssign;
		
		public static  haxe.macro.Binop OpEq;
		
		public static  haxe.macro.Binop OpNotEq;
		
		public static  haxe.macro.Binop OpGt;
		
		public static  haxe.macro.Binop OpGte;
		
		public static  haxe.macro.Binop OpLt;
		
		public static  haxe.macro.Binop OpLte;
		
		public static  haxe.macro.Binop OpAnd;
		
		public static  haxe.macro.Binop OpOr;
		
		public static  haxe.macro.Binop OpXor;
		
		public static  haxe.macro.Binop OpBoolAnd;
		
		public static  haxe.macro.Binop OpBoolOr;
		
		public static  haxe.macro.Binop OpShl;
		
		public static  haxe.macro.Binop OpShr;
		
		public static  haxe.macro.Binop OpUShr;
		
		public static  haxe.macro.Binop OpMod;
		
		public static   haxe.macro.Binop OpAssignOp(haxe.macro.Binop op)
		{
			unchecked 
			{
				return new haxe.macro.Binop(20, new Array<object>(new object[]{op}));
			}
		}
		
		
		public static  haxe.macro.Binop OpInterval;
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.Binop.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.Binop.__hx_class) : (haxe.macro.Binop.__hx_class = new haxe.lang.Class(new haxe.macro.Binop(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    Binop(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
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
						case 583476134:
						{
							return haxe.macro.Binop.OpInterval = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1189775361:
						{
							return haxe.macro.Binop.OpMod = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1266741929:
						{
							return haxe.macro.Binop.OpUShr = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1190072188:
						{
							return haxe.macro.Binop.OpShr = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1190072182:
						{
							return haxe.macro.Binop.OpShl = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1856915470:
						{
							return haxe.macro.Binop.OpBoolOr = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1774592396:
						{
							return haxe.macro.Binop.OpBoolAnd = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1190322394:
						{
							return haxe.macro.Binop.OpXor = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 881663172:
						{
							return haxe.macro.Binop.OpOr = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1189178390:
						{
							return haxe.macro.Binop.OpAnd = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1189726748:
						{
							return haxe.macro.Binop.OpLte = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 881662505:
						{
							return haxe.macro.Binop.OpLt = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1189478103:
						{
							return haxe.macro.Binop.OpGte = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 881661390:
						{
							return haxe.macro.Binop.OpGt = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1343242078:
						{
							return haxe.macro.Binop.OpNotEq = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 881660941:
						{
							return haxe.macro.Binop.OpEq = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1485825616:
						{
							return haxe.macro.Binop.OpAssign = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1190075071:
						{
							return haxe.macro.Binop.OpSub = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1189326480:
						{
							return haxe.macro.Binop.OpDiv = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1179717073:
						{
							return haxe.macro.Binop.OpMult = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1189176160:
						{
							return haxe.macro.Binop.OpAdd = ((haxe.macro.Binop) (@value) );
						}
						
						
						case 1744813180:
						{
							return haxe.macro.Binop.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
						case 583476134:
						{
							return haxe.macro.Binop.OpInterval;
						}
						
						
						case 152199057:
						{
							return new haxe.lang.Closure("OpAssignOp", 152199057, ((haxe.lang.IHxObject) (haxe.macro.Binop.__hx_getClassStatic()) ));
						}
						
						
						case 1189775361:
						{
							return haxe.macro.Binop.OpMod;
						}
						
						
						case 1266741929:
						{
							return haxe.macro.Binop.OpUShr;
						}
						
						
						case 1190072188:
						{
							return haxe.macro.Binop.OpShr;
						}
						
						
						case 1190072182:
						{
							return haxe.macro.Binop.OpShl;
						}
						
						
						case 1856915470:
						{
							return haxe.macro.Binop.OpBoolOr;
						}
						
						
						case 1774592396:
						{
							return haxe.macro.Binop.OpBoolAnd;
						}
						
						
						case 1190322394:
						{
							return haxe.macro.Binop.OpXor;
						}
						
						
						case 881663172:
						{
							return haxe.macro.Binop.OpOr;
						}
						
						
						case 1189178390:
						{
							return haxe.macro.Binop.OpAnd;
						}
						
						
						case 1189726748:
						{
							return haxe.macro.Binop.OpLte;
						}
						
						
						case 881662505:
						{
							return haxe.macro.Binop.OpLt;
						}
						
						
						case 1189478103:
						{
							return haxe.macro.Binop.OpGte;
						}
						
						
						case 881661390:
						{
							return haxe.macro.Binop.OpGt;
						}
						
						
						case 1343242078:
						{
							return haxe.macro.Binop.OpNotEq;
						}
						
						
						case 881660941:
						{
							return haxe.macro.Binop.OpEq;
						}
						
						
						case 1485825616:
						{
							return haxe.macro.Binop.OpAssign;
						}
						
						
						case 1190075071:
						{
							return haxe.macro.Binop.OpSub;
						}
						
						
						case 1189326480:
						{
							return haxe.macro.Binop.OpDiv;
						}
						
						
						case 1179717073:
						{
							return haxe.macro.Binop.OpMult;
						}
						
						
						case 1189176160:
						{
							return haxe.macro.Binop.OpAdd;
						}
						
						
						case 1744813180:
						{
							return haxe.macro.Binop.constructs;
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
						case 152199057:
						{
							return haxe.macro.Binop.OpAssignOp(((haxe.macro.Binop) (dynargs[0]) ));
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
				baseArr.push("OpInterval");
				baseArr.push("OpAssignOp");
				baseArr.push("OpMod");
				baseArr.push("OpUShr");
				baseArr.push("OpShr");
				baseArr.push("OpShl");
				baseArr.push("OpBoolOr");
				baseArr.push("OpBoolAnd");
				baseArr.push("OpXor");
				baseArr.push("OpOr");
				baseArr.push("OpAnd");
				baseArr.push("OpLte");
				baseArr.push("OpLt");
				baseArr.push("OpGte");
				baseArr.push("OpGt");
				baseArr.push("OpNotEq");
				baseArr.push("OpEq");
				baseArr.push("OpAssign");
				baseArr.push("OpSub");
				baseArr.push("OpDiv");
				baseArr.push("OpMult");
				baseArr.push("OpAdd");
				baseArr.push("constructs");
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
				return ((haxe.lang.Class) (( (( haxe.macro.Binop.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.Binop.__hx_class) : (haxe.macro.Binop.__hx_class = new haxe.lang.Class(new haxe.macro.Binop(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.Binop(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.Binop(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
	}
}



namespace haxe.macro
{
	public enum Unop
	{
		OpIncrement, OpDecrement, OpNot, OpNeg, OpNegBits
	}
}



namespace haxe.macro
{
	public  class ExprDef : haxe.lang.Enum 
	{
		static ExprDef() 
		{
			haxe.macro.ExprDef.constructs = new Array<object>(new object[]{"EConst", "EArray", "EBinop", "EField", "EParenthesis", "EObjectDecl", "EArrayDecl", "ECall", "ENew", "EUnop", "EVars", "EFunction", "EBlock", "EFor", "EIn", "EIf", "EWhile", "ESwitch", "ETry", "EReturn", "EBreak", "EContinue", "EUntyped", "EThrow", "ECast", "EDisplay", "EDisplayNew", "ETernary", "ECheckType", "EMacro", "EType"});
			haxe.macro.ExprDef.EBreak = new haxe.macro.ExprDef(20, default(Array<object>));
			haxe.macro.ExprDef.EContinue = new haxe.macro.ExprDef(21, default(Array<object>));
		}
		public    ExprDef(int index, Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
				haxe.macro.ExprDef.__hx_ctor(this, index, @params);
			}
		}
		
		
		public static   void __hx_ctor(haxe.macro.ExprDef __temp_me22, int index, Array<object> @params)
		{
			unchecked 
			{
				object __temp_expr60 = default(object);
			}
		}
		
		
		public static  Array<object> constructs;
		
		public static   haxe.macro.ExprDef EConst(haxe.macro.Constant c)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(0, new Array<object>(new object[]{c}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EArray(object e1, object e2)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(1, new Array<object>(new object[]{e1, e2}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EBinop(haxe.macro.Binop op, object e1, object e2)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(2, new Array<object>(new object[]{op, e1, e2}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EField(object e, string field)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(3, new Array<object>(new object[]{e, field}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EParenthesis(object e)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(4, new Array<object>(new object[]{e}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EObjectDecl(Array<object> fields)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(5, new Array<object>(new object[]{fields}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EArrayDecl(Array<object> values)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(6, new Array<object>(new object[]{values}));
			}
		}
		
		
		public static   haxe.macro.ExprDef ECall(object e, Array<object> @params)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(7, new Array<object>(new object[]{e, @params}));
			}
		}
		
		
		public static   haxe.macro.ExprDef ENew(object t, Array<object> @params)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(8, new Array<object>(new object[]{t, @params}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EUnop(haxe.macro.Unop op, bool postFix, object e)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(9, new Array<object>(new object[]{op, postFix, e}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EVars(Array<object> vars)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(10, new Array<object>(new object[]{vars}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EFunction(string name, object f)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(11, new Array<object>(new object[]{name, f}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EBlock(Array<object> exprs)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(12, new Array<object>(new object[]{exprs}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EFor(object it, object expr)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(13, new Array<object>(new object[]{it, expr}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EIn(object e1, object e2)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(14, new Array<object>(new object[]{e1, e2}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EIf(object econd, object eif, object eelse)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(15, new Array<object>(new object[]{econd, eif, eelse}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EWhile(object econd, object e, bool normalWhile)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(16, new Array<object>(new object[]{econd, e, normalWhile}));
			}
		}
		
		
		public static   haxe.macro.ExprDef ESwitch(object e, Array<object> cases, object edef)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(17, new Array<object>(new object[]{e, cases, edef}));
			}
		}
		
		
		public static   haxe.macro.ExprDef ETry(object e, Array<object> catches)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(18, new Array<object>(new object[]{e, catches}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EReturn(object e)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(19, new Array<object>(new object[]{e}));
			}
		}
		
		
		public static  haxe.macro.ExprDef EBreak;
		
		public static  haxe.macro.ExprDef EContinue;
		
		public static   haxe.macro.ExprDef EUntyped(object e)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(22, new Array<object>(new object[]{e}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EThrow(object e)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(23, new Array<object>(new object[]{e}));
			}
		}
		
		
		public static   haxe.macro.ExprDef ECast(object e, haxe.macro.ComplexType t)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(24, new Array<object>(new object[]{e, t}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EDisplay(object e, bool isCall)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(25, new Array<object>(new object[]{e, isCall}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EDisplayNew(object t)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(26, new Array<object>(new object[]{t}));
			}
		}
		
		
		public static   haxe.macro.ExprDef ETernary(object econd, object eif, object eelse)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(27, new Array<object>(new object[]{econd, eif, eelse}));
			}
		}
		
		
		public static   haxe.macro.ExprDef ECheckType(object e, haxe.macro.ComplexType t)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(28, new Array<object>(new object[]{e, t}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EMacro(object e)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(29, new Array<object>(new object[]{e}));
			}
		}
		
		
		public static   haxe.macro.ExprDef EType(object e, string field)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(30, new Array<object>(new object[]{e, field}));
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.ExprDef.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.ExprDef.__hx_class) : (haxe.macro.ExprDef.__hx_class = new haxe.lang.Class(new haxe.macro.ExprDef(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    ExprDef(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
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
						case 1720445388:
						{
							return haxe.macro.ExprDef.EContinue = ((haxe.macro.ExprDef) (@value) );
						}
						
						
						case 1656322618:
						{
							return haxe.macro.ExprDef.EBreak = ((haxe.macro.ExprDef) (@value) );
						}
						
						
						case 1744813180:
						{
							return haxe.macro.ExprDef.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
						case 1921525151:
						{
							return new haxe.lang.Closure("EType", 1921525151, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 753124743:
						{
							return new haxe.lang.Closure("EMacro", 753124743, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 382593693:
						{
							return new haxe.lang.Closure("ECheckType", 382593693, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1583137622:
						{
							return new haxe.lang.Closure("ETernary", 1583137622, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 275488739:
						{
							return new haxe.lang.Closure("EDisplayNew", 275488739, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1932792957:
						{
							return new haxe.lang.Closure("EDisplay", 1932792957, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1731809700:
						{
							return new haxe.lang.Closure("ECast", 1731809700, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 962441889:
						{
							return new haxe.lang.Closure("EThrow", 962441889, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1330008492:
						{
							return new haxe.lang.Closure("EUntyped", 1330008492, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1720445388:
						{
							return haxe.macro.ExprDef.EContinue;
						}
						
						
						case 1656322618:
						{
							return haxe.macro.ExprDef.EBreak;
						}
						
						
						case 1930107605:
						{
							return new haxe.lang.Closure("EReturn", 1930107605, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 769382902:
						{
							return new haxe.lang.Closure("ETry", 769382902, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 794214425:
						{
							return new haxe.lang.Closure("ESwitch", 794214425, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1938463020:
						{
							return new haxe.lang.Closure("EWhile", 1938463020, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 3447682:
						{
							return new haxe.lang.Closure("EIf", 3447682, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 3447690:
						{
							return new haxe.lang.Closure("EIn", 3447690, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 768686020:
						{
							return new haxe.lang.Closure("EFor", 768686020, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1590282952:
						{
							return new haxe.lang.Closure("EBlock", 1590282952, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1226159229:
						{
							return new haxe.lang.Closure("EFunction", 1226159229, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1942511249:
						{
							return new haxe.lang.Closure("EVars", 1942511249, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1932067487:
						{
							return new haxe.lang.Closure("EUnop", 1932067487, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 769081627:
						{
							return new haxe.lang.Closure("ENew", 769081627, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1731808131:
						{
							return new haxe.lang.Closure("ECall", 1731808131, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 29186462:
						{
							return new haxe.lang.Closure("EArrayDecl", 29186462, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 2000860014:
						{
							return new haxe.lang.Closure("EObjectDecl", 2000860014, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1058973329:
						{
							return new haxe.lang.Closure("EParenthesis", 1058973329, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 710994485:
						{
							return new haxe.lang.Closure("EField", 710994485, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1556967203:
						{
							return new haxe.lang.Closure("EBinop", 1556967203, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1331479316:
						{
							return new haxe.lang.Closure("EArray", 1331479316, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1948995294:
						{
							return new haxe.lang.Closure("EConst", 1948995294, ((haxe.lang.IHxObject) (haxe.macro.ExprDef.__hx_getClassStatic()) ));
						}
						
						
						case 1744813180:
						{
							return haxe.macro.ExprDef.constructs;
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
						case 1921525151:
						{
							return haxe.macro.ExprDef.EType(((object) (dynargs[0]) ), (( dynargs[1] + "" )));
						}
						
						
						case 753124743:
						{
							return haxe.macro.ExprDef.EMacro(((object) (dynargs[0]) ));
						}
						
						
						case 382593693:
						{
							return haxe.macro.ExprDef.ECheckType(((object) (dynargs[0]) ), ((haxe.macro.ComplexType) (dynargs[1]) ));
						}
						
						
						case 1583137622:
						{
							return haxe.macro.ExprDef.ETernary(((object) (dynargs[0]) ), ((object) (dynargs[1]) ), ((object) (dynargs[2]) ));
						}
						
						
						case 275488739:
						{
							return haxe.macro.ExprDef.EDisplayNew(((object) (dynargs[0]) ));
						}
						
						
						case 1932792957:
						{
							return haxe.macro.ExprDef.EDisplay(((object) (dynargs[0]) ), ((bool) (dynargs[1]) ));
						}
						
						
						case 1731809700:
						{
							return haxe.macro.ExprDef.ECast(((object) (dynargs[0]) ), ((haxe.macro.ComplexType) (dynargs[1]) ));
						}
						
						
						case 962441889:
						{
							return haxe.macro.ExprDef.EThrow(((object) (dynargs[0]) ));
						}
						
						
						case 1330008492:
						{
							return haxe.macro.ExprDef.EUntyped(((object) (dynargs[0]) ));
						}
						
						
						case 1930107605:
						{
							return haxe.macro.ExprDef.EReturn(((object) (dynargs[0]) ));
						}
						
						
						case 769382902:
						{
							return haxe.macro.ExprDef.ETry(((object) (dynargs[0]) ), ((Array<object>) (((Array) (dynargs[1]) ).cast<object>()) ));
						}
						
						
						case 794214425:
						{
							return haxe.macro.ExprDef.ESwitch(((object) (dynargs[0]) ), ((Array<object>) (((Array) (dynargs[1]) ).cast<object>()) ), ((object) (dynargs[2]) ));
						}
						
						
						case 1938463020:
						{
							return haxe.macro.ExprDef.EWhile(((object) (dynargs[0]) ), ((object) (dynargs[1]) ), ((bool) (dynargs[2]) ));
						}
						
						
						case 3447682:
						{
							return haxe.macro.ExprDef.EIf(((object) (dynargs[0]) ), ((object) (dynargs[1]) ), ((object) (dynargs[2]) ));
						}
						
						
						case 3447690:
						{
							return haxe.macro.ExprDef.EIn(((object) (dynargs[0]) ), ((object) (dynargs[1]) ));
						}
						
						
						case 768686020:
						{
							return haxe.macro.ExprDef.EFor(((object) (dynargs[0]) ), ((object) (dynargs[1]) ));
						}
						
						
						case 1590282952:
						{
							return haxe.macro.ExprDef.EBlock(((Array<object>) (((Array) (dynargs[0]) ).cast<object>()) ));
						}
						
						
						case 1226159229:
						{
							return haxe.macro.ExprDef.EFunction((( dynargs[0] + "" )), ((object) (dynargs[1]) ));
						}
						
						
						case 1942511249:
						{
							return haxe.macro.ExprDef.EVars(((Array<object>) (((Array) (dynargs[0]) ).cast<object>()) ));
						}
						
						
						case 1932067487:
						{
							return haxe.macro.ExprDef.EUnop(((haxe.macro.Unop) (dynargs[0]) ), ((bool) (dynargs[1]) ), ((object) (dynargs[2]) ));
						}
						
						
						case 769081627:
						{
							return haxe.macro.ExprDef.ENew(((object) (dynargs[0]) ), ((Array<object>) (((Array) (dynargs[1]) ).cast<object>()) ));
						}
						
						
						case 1731808131:
						{
							return haxe.macro.ExprDef.ECall(((object) (dynargs[0]) ), ((Array<object>) (((Array) (dynargs[1]) ).cast<object>()) ));
						}
						
						
						case 29186462:
						{
							return haxe.macro.ExprDef.EArrayDecl(((Array<object>) (((Array) (dynargs[0]) ).cast<object>()) ));
						}
						
						
						case 2000860014:
						{
							return haxe.macro.ExprDef.EObjectDecl(((Array<object>) (((Array) (dynargs[0]) ).cast<object>()) ));
						}
						
						
						case 1058973329:
						{
							return haxe.macro.ExprDef.EParenthesis(((object) (dynargs[0]) ));
						}
						
						
						case 710994485:
						{
							return haxe.macro.ExprDef.EField(((object) (dynargs[0]) ), (( dynargs[1] + "" )));
						}
						
						
						case 1556967203:
						{
							return haxe.macro.ExprDef.EBinop(((haxe.macro.Binop) (dynargs[0]) ), ((object) (dynargs[1]) ), ((object) (dynargs[2]) ));
						}
						
						
						case 1331479316:
						{
							return haxe.macro.ExprDef.EArray(((object) (dynargs[0]) ), ((object) (dynargs[1]) ));
						}
						
						
						case 1948995294:
						{
							return haxe.macro.ExprDef.EConst(((haxe.macro.Constant) (dynargs[0]) ));
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
				baseArr.push("EType");
				baseArr.push("EMacro");
				baseArr.push("ECheckType");
				baseArr.push("ETernary");
				baseArr.push("EDisplayNew");
				baseArr.push("EDisplay");
				baseArr.push("ECast");
				baseArr.push("EThrow");
				baseArr.push("EUntyped");
				baseArr.push("EContinue");
				baseArr.push("EBreak");
				baseArr.push("EReturn");
				baseArr.push("ETry");
				baseArr.push("ESwitch");
				baseArr.push("EWhile");
				baseArr.push("EIf");
				baseArr.push("EIn");
				baseArr.push("EFor");
				baseArr.push("EBlock");
				baseArr.push("EFunction");
				baseArr.push("EVars");
				baseArr.push("EUnop");
				baseArr.push("ENew");
				baseArr.push("ECall");
				baseArr.push("EArrayDecl");
				baseArr.push("EObjectDecl");
				baseArr.push("EParenthesis");
				baseArr.push("EField");
				baseArr.push("EBinop");
				baseArr.push("EArray");
				baseArr.push("EConst");
				baseArr.push("constructs");
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
				return ((haxe.lang.Class) (( (( haxe.macro.ExprDef.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.ExprDef.__hx_class) : (haxe.macro.ExprDef.__hx_class = new haxe.lang.Class(new haxe.macro.ExprDef(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.ExprDef(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
	}
}



namespace haxe.macro
{
	public  class ComplexType : haxe.lang.Enum 
	{
		static ComplexType() 
		{
			haxe.macro.ComplexType.constructs = new Array<object>(new object[]{"TPath", "TFunction", "TAnonymous", "TParent", "TExtend", "TOptional"});
		}
		public    ComplexType(int index, Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
				haxe.macro.ComplexType.__hx_ctor(this, index, @params);
			}
		}
		
		
		public static   void __hx_ctor(haxe.macro.ComplexType __temp_me23, int index, Array<object> @params)
		{
			unchecked 
			{
				object __temp_expr61 = default(object);
			}
		}
		
		
		public static  Array<object> constructs;
		
		public static   haxe.macro.ComplexType TPath(object p)
		{
			unchecked 
			{
				return new haxe.macro.ComplexType(0, new Array<object>(new object[]{p}));
			}
		}
		
		
		public static   haxe.macro.ComplexType TFunction(Array<object> args, haxe.macro.ComplexType ret)
		{
			unchecked 
			{
				return new haxe.macro.ComplexType(1, new Array<object>(new object[]{args, ret}));
			}
		}
		
		
		public static   haxe.macro.ComplexType TAnonymous(Array<object> fields)
		{
			unchecked 
			{
				return new haxe.macro.ComplexType(2, new Array<object>(new object[]{fields}));
			}
		}
		
		
		public static   haxe.macro.ComplexType TParent(haxe.macro.ComplexType t)
		{
			unchecked 
			{
				return new haxe.macro.ComplexType(3, new Array<object>(new object[]{t}));
			}
		}
		
		
		public static   haxe.macro.ComplexType TExtend(object p, Array<object> fields)
		{
			unchecked 
			{
				return new haxe.macro.ComplexType(4, new Array<object>(new object[]{p, fields}));
			}
		}
		
		
		public static   haxe.macro.ComplexType TOptional(haxe.macro.ComplexType t)
		{
			unchecked 
			{
				return new haxe.macro.ComplexType(5, new Array<object>(new object[]{t}));
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.ComplexType.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.ComplexType.__hx_class) : (haxe.macro.ComplexType.__hx_class = new haxe.lang.Class(new haxe.macro.ComplexType(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    ComplexType(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
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
						case 1744813180:
						{
							return haxe.macro.ComplexType.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
						case 794222612:
						{
							return new haxe.lang.Closure("TOptional", 794222612, ((haxe.lang.IHxObject) (haxe.macro.ComplexType.__hx_getClassStatic()) ));
						}
						
						
						case 549076302:
						{
							return new haxe.lang.Closure("TExtend", 549076302, ((haxe.lang.IHxObject) (haxe.macro.ComplexType.__hx_getClassStatic()) ));
						}
						
						
						case 1193111710:
						{
							return new haxe.lang.Closure("TParent", 1193111710, ((haxe.lang.IHxObject) (haxe.macro.ComplexType.__hx_getClassStatic()) ));
						}
						
						
						case 844450169:
						{
							return new haxe.lang.Closure("TAnonymous", 844450169, ((haxe.lang.IHxObject) (haxe.macro.ComplexType.__hx_getClassStatic()) ));
						}
						
						
						case 624614284:
						{
							return new haxe.lang.Closure("TFunction", 624614284, ((haxe.lang.IHxObject) (haxe.macro.ComplexType.__hx_getClassStatic()) ));
						}
						
						
						case 315870233:
						{
							return new haxe.lang.Closure("TPath", 315870233, ((haxe.lang.IHxObject) (haxe.macro.ComplexType.__hx_getClassStatic()) ));
						}
						
						
						case 1744813180:
						{
							return haxe.macro.ComplexType.constructs;
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
						case 794222612:
						{
							return haxe.macro.ComplexType.TOptional(((haxe.macro.ComplexType) (dynargs[0]) ));
						}
						
						
						case 549076302:
						{
							return haxe.macro.ComplexType.TExtend(((object) (dynargs[0]) ), ((Array<object>) (((Array) (dynargs[1]) ).cast<object>()) ));
						}
						
						
						case 1193111710:
						{
							return haxe.macro.ComplexType.TParent(((haxe.macro.ComplexType) (dynargs[0]) ));
						}
						
						
						case 844450169:
						{
							return haxe.macro.ComplexType.TAnonymous(((Array<object>) (((Array) (dynargs[0]) ).cast<object>()) ));
						}
						
						
						case 624614284:
						{
							return haxe.macro.ComplexType.TFunction(((Array<object>) (((Array) (dynargs[0]) ).cast<object>()) ), ((haxe.macro.ComplexType) (dynargs[1]) ));
						}
						
						
						case 315870233:
						{
							return haxe.macro.ComplexType.TPath(((object) (dynargs[0]) ));
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
				baseArr.push("TOptional");
				baseArr.push("TExtend");
				baseArr.push("TParent");
				baseArr.push("TAnonymous");
				baseArr.push("TFunction");
				baseArr.push("TPath");
				baseArr.push("constructs");
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
				return ((haxe.lang.Class) (( (( haxe.macro.ComplexType.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.ComplexType.__hx_class) : (haxe.macro.ComplexType.__hx_class = new haxe.lang.Class(new haxe.macro.ComplexType(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.ComplexType(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.ComplexType(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
	}
}



namespace haxe.macro
{
	public  class TypeParam : haxe.lang.Enum 
	{
		static TypeParam() 
		{
			haxe.macro.TypeParam.constructs = new Array<object>(new object[]{"TPType", "TPExpr"});
		}
		public    TypeParam(int index, Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
				haxe.macro.TypeParam.__hx_ctor(this, index, @params);
			}
		}
		
		
		public static   void __hx_ctor(haxe.macro.TypeParam __temp_me24, int index, Array<object> @params)
		{
			unchecked 
			{
				object __temp_expr62 = default(object);
			}
		}
		
		
		public static  Array<object> constructs;
		
		public static   haxe.macro.TypeParam TPType(haxe.macro.ComplexType t)
		{
			unchecked 
			{
				return new haxe.macro.TypeParam(0, new Array<object>(new object[]{t}));
			}
		}
		
		
		public static   haxe.macro.TypeParam TPExpr(object e)
		{
			unchecked 
			{
				return new haxe.macro.TypeParam(1, new Array<object>(new object[]{e}));
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.TypeParam.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.TypeParam.__hx_class) : (haxe.macro.TypeParam.__hx_class = new haxe.lang.Class(new haxe.macro.TypeParam(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    TypeParam(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
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
						case 1744813180:
						{
							return haxe.macro.TypeParam.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
						case 1409278161:
						{
							return new haxe.lang.Closure("TPExpr", 1409278161, ((haxe.lang.IHxObject) (haxe.macro.TypeParam.__hx_getClassStatic()) ));
						}
						
						
						case 1575671382:
						{
							return new haxe.lang.Closure("TPType", 1575671382, ((haxe.lang.IHxObject) (haxe.macro.TypeParam.__hx_getClassStatic()) ));
						}
						
						
						case 1744813180:
						{
							return haxe.macro.TypeParam.constructs;
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
						case 1409278161:
						{
							return haxe.macro.TypeParam.TPExpr(((object) (dynargs[0]) ));
						}
						
						
						case 1575671382:
						{
							return haxe.macro.TypeParam.TPType(((haxe.macro.ComplexType) (dynargs[0]) ));
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
				baseArr.push("TPExpr");
				baseArr.push("TPType");
				baseArr.push("constructs");
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
				return ((haxe.lang.Class) (( (( haxe.macro.TypeParam.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.TypeParam.__hx_class) : (haxe.macro.TypeParam.__hx_class = new haxe.lang.Class(new haxe.macro.TypeParam(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.TypeParam(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.TypeParam(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
	}
}



namespace haxe.macro
{
	public enum Access
	{
		APublic, APrivate, AStatic, AOverride, ADynamic, AInline
	}
}



namespace haxe.macro
{
	public  class FieldType : haxe.lang.Enum 
	{
		static FieldType() 
		{
			haxe.macro.FieldType.constructs = new Array<object>(new object[]{"FVar", "FFun", "FProp"});
		}
		public    FieldType(int index, Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
				haxe.macro.FieldType.__hx_ctor(this, index, @params);
			}
		}
		
		
		public static   void __hx_ctor(haxe.macro.FieldType __temp_me25, int index, Array<object> @params)
		{
			unchecked 
			{
				object __temp_expr63 = default(object);
			}
		}
		
		
		public static  Array<object> constructs;
		
		public static   haxe.macro.FieldType FVar(haxe.macro.ComplexType t, object e)
		{
			unchecked 
			{
				return new haxe.macro.FieldType(0, new Array<object>(new object[]{t, e}));
			}
		}
		
		
		public static   haxe.macro.FieldType FFun(object f)
		{
			unchecked 
			{
				return new haxe.macro.FieldType(1, new Array<object>(new object[]{f}));
			}
		}
		
		
		public static   haxe.macro.FieldType FProp(string @get, string @set, haxe.macro.ComplexType t, object e)
		{
			unchecked 
			{
				return new haxe.macro.FieldType(2, new Array<object>(new object[]{@get, @set, t, e}));
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.FieldType.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.FieldType.__hx_class) : (haxe.macro.FieldType.__hx_class = new haxe.lang.Class(new haxe.macro.FieldType(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    FieldType(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
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
						case 1744813180:
						{
							return haxe.macro.FieldType.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
						case 54824713:
						{
							return new haxe.lang.Closure("FProp", 54824713, ((haxe.lang.IHxObject) (haxe.macro.FieldType.__hx_getClassStatic()) ));
						}
						
						
						case 779776921:
						{
							return new haxe.lang.Closure("FFun", 779776921, ((haxe.lang.IHxObject) (haxe.macro.FieldType.__hx_getClassStatic()) ));
						}
						
						
						case 780568129:
						{
							return new haxe.lang.Closure("FVar", 780568129, ((haxe.lang.IHxObject) (haxe.macro.FieldType.__hx_getClassStatic()) ));
						}
						
						
						case 1744813180:
						{
							return haxe.macro.FieldType.constructs;
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
						case 54824713:
						{
							return haxe.macro.FieldType.FProp((( dynargs[0] + "" )), (( dynargs[1] + "" )), ((haxe.macro.ComplexType) (dynargs[2]) ), ((object) (dynargs[3]) ));
						}
						
						
						case 779776921:
						{
							return haxe.macro.FieldType.FFun(((object) (dynargs[0]) ));
						}
						
						
						case 780568129:
						{
							return haxe.macro.FieldType.FVar(((haxe.macro.ComplexType) (dynargs[0]) ), ((object) (dynargs[1]) ));
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
				baseArr.push("FProp");
				baseArr.push("FFun");
				baseArr.push("FVar");
				baseArr.push("constructs");
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
				return ((haxe.lang.Class) (( (( haxe.macro.FieldType.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.FieldType.__hx_class) : (haxe.macro.FieldType.__hx_class = new haxe.lang.Class(new haxe.macro.FieldType(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.FieldType(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.FieldType(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
	}
}



namespace haxe.macro
{
	public  class TypeDefKind : haxe.lang.Enum 
	{
		static TypeDefKind() 
		{
			haxe.macro.TypeDefKind.constructs = new Array<object>(new object[]{"TDEnum", "TDStructure", "TDClass"});
			haxe.macro.TypeDefKind.TDEnum = new haxe.macro.TypeDefKind(0, default(Array<object>));
			haxe.macro.TypeDefKind.TDStructure = new haxe.macro.TypeDefKind(1, default(Array<object>));
		}
		public    TypeDefKind(int index, Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
				haxe.macro.TypeDefKind.__hx_ctor(this, index, @params);
			}
		}
		
		
		public static   void __hx_ctor(haxe.macro.TypeDefKind __temp_me26, int index, Array<object> @params)
		{
			unchecked 
			{
				object __temp_expr64 = default(object);
			}
		}
		
		
		public static  Array<object> constructs;
		
		public static  haxe.macro.TypeDefKind TDEnum;
		
		public static  haxe.macro.TypeDefKind TDStructure;
		
		public static   haxe.macro.TypeDefKind TDClass(object extend, Array<object> implement, haxe.lang.Null<bool> isInterface)
		{
			unchecked 
			{
				return new haxe.macro.TypeDefKind(2, new Array<object>(new object[]{extend, implement, (isInterface).toDynamic()}));
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.TypeDefKind.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.TypeDefKind.__hx_class) : (haxe.macro.TypeDefKind.__hx_class = new haxe.lang.Class(new haxe.macro.TypeDefKind(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    TypeDefKind(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
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
						case 1172651171:
						{
							return haxe.macro.TypeDefKind.TDStructure = ((haxe.macro.TypeDefKind) (@value) );
						}
						
						
						case 1797871761:
						{
							return haxe.macro.TypeDefKind.TDEnum = ((haxe.macro.TypeDefKind) (@value) );
						}
						
						
						case 1744813180:
						{
							return haxe.macro.TypeDefKind.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
						case 819292328:
						{
							return new haxe.lang.Closure("TDClass", 819292328, ((haxe.lang.IHxObject) (haxe.macro.TypeDefKind.__hx_getClassStatic()) ));
						}
						
						
						case 1172651171:
						{
							return haxe.macro.TypeDefKind.TDStructure;
						}
						
						
						case 1797871761:
						{
							return haxe.macro.TypeDefKind.TDEnum;
						}
						
						
						case 1744813180:
						{
							return haxe.macro.TypeDefKind.constructs;
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
						case 819292328:
						{
							return haxe.macro.TypeDefKind.TDClass(((object) (dynargs[0]) ), ((Array<object>) (((Array) (dynargs[1]) ).cast<object>()) ), haxe.lang.Null<object>.ofDynamic<bool>(dynargs[2]));
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
				baseArr.push("TDClass");
				baseArr.push("TDStructure");
				baseArr.push("TDEnum");
				baseArr.push("constructs");
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
				return ((haxe.lang.Class) (( (( haxe.macro.TypeDefKind.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.TypeDefKind.__hx_class) : (haxe.macro.TypeDefKind.__hx_class = new haxe.lang.Class(new haxe.macro.TypeDefKind(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.TypeDefKind(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.TypeDefKind(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
	}
}



namespace haxe.macro
{
	public  class Error : haxe.lang.HxObject 
	{
		public    Error(string m, object p) : base()
		{
			unchecked 
			{
				haxe.macro.Error.__hx_ctor(this, m, p);
			}
		}
		
		
		public static   void __hx_ctor(haxe.macro.Error __temp_me27, string m, object p)
		{
			unchecked 
			{
				__temp_me27.message = m;
				__temp_me27.pos = p;
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.Error.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.Error.__hx_class) : (haxe.macro.Error.__hx_class = new haxe.lang.Class(new haxe.macro.Error(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    Error(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
		public  string message;
		
		public  object pos;
		
		public override   object __hx_setField(string field, int hash, bool isStatic, object @value)
		{
			unchecked 
			{
				if (isStatic) 
				{
					switch (hash)
					{
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
						case 5594516:
						{
							return this.pos = ((object) (@value) );
						}
						
						
						case 437335495:
						{
							return this.message = (( @value + "" ));
						}
						
						
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
						case 5594516:
						{
							return this.pos;
						}
						
						
						case 437335495:
						{
							return this.message;
						}
						
						
						default:
						{
							return base.__hx_getField(field, hash, isStatic, throwErrors, isCheck);
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_classFields(Array<object> baseArr)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public override   void __hx_getFields(Array<object> baseArr, bool isInstanceFields)
		{
			unchecked 
			{
				baseArr.push("pos");
				baseArr.push("message");
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
				return ((haxe.lang.Class) (( (( haxe.macro.Error.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.Error.__hx_class) : (haxe.macro.Error.__hx_class = new haxe.lang.Class(new haxe.macro.Error(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.Error(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.Error((( arr[0] + "" )), ((object) (arr[1]) ));
			}
		}
		
		
	}
}


