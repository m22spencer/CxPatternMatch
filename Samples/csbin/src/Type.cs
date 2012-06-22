
public  class ValueType : haxe.lang.Enum 
{
	static ValueType() 
	{
		ValueType.constructs = new Array<object>(new object[]{"TNull", "TInt", "TFloat", "TBool", "TObject", "TFunction", "TClass", "TEnum", "TUnknown"});
		ValueType.TNull = new ValueType(0, default(Array<object>));
		ValueType.TInt = new ValueType(1, default(Array<object>));
		ValueType.TFloat = new ValueType(2, default(Array<object>));
		ValueType.TBool = new ValueType(3, default(Array<object>));
		ValueType.TObject = new ValueType(4, default(Array<object>));
		ValueType.TFunction = new ValueType(5, default(Array<object>));
		ValueType.TUnknown = new ValueType(8, default(Array<object>));
	}
	public    ValueType(int index, Array<object> @params) : base(index, @params)
	{
		unchecked 
		{
			ValueType.__hx_ctor(this, index, @params);
		}
	}
	
	
	public static   void __hx_ctor(ValueType __temp_me10, int index, Array<object> @params)
	{
		unchecked 
		{
			object __temp_expr56 = default(object);
		}
	}
	
	
	public static  Array<object> constructs;
	
	public static  ValueType TNull;
	
	public static  ValueType TInt;
	
	public static  ValueType TFloat;
	
	public static  ValueType TBool;
	
	public static  ValueType TObject;
	
	public static  ValueType TFunction;
	
	public static   ValueType TClass(haxe.lang.Class c)
	{
		unchecked 
		{
			return new ValueType(6, new Array<object>(new object[]{c}));
		}
	}
	
	
	public static   ValueType TEnum(haxe.lang.Class e)
	{
		unchecked 
		{
			return new ValueType(7, new Array<object>(new object[]{e}));
		}
	}
	
	
	public static  ValueType TUnknown;
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( ValueType.__hx_class != default(haxe.lang.Class) )) ? (ValueType.__hx_class) : (ValueType.__hx_class = new haxe.lang.Class(new ValueType(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    ValueType(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
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
					case 1935261078:
					{
						return ValueType.TUnknown = ((ValueType) (@value) );
					}
					
					
					case 624614284:
					{
						return ValueType.TFunction = ((ValueType) (@value) );
					}
					
					
					case 1860102707:
					{
						return ValueType.TObject = ((ValueType) (@value) );
					}
					
					
					case 161311390:
					{
						return ValueType.TBool = ((ValueType) (@value) );
					}
					
					
					case 733906088:
					{
						return ValueType.TFloat = ((ValueType) (@value) );
					}
					
					
					case 935178491:
					{
						return ValueType.TInt = ((ValueType) (@value) );
					}
					
					
					case 294683899:
					{
						return ValueType.TNull = ((ValueType) (@value) );
					}
					
					
					case 1744813180:
					{
						return ValueType.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
					case 1935261078:
					{
						return ValueType.TUnknown;
					}
					
					
					case 194531701:
					{
						return new haxe.lang.Closure("TEnum", 194531701, ((haxe.lang.IHxObject) (ValueType.__hx_getClassStatic()) ));
					}
					
					
					case 1904228164:
					{
						return new haxe.lang.Closure("TClass", 1904228164, ((haxe.lang.IHxObject) (ValueType.__hx_getClassStatic()) ));
					}
					
					
					case 624614284:
					{
						return ValueType.TFunction;
					}
					
					
					case 1860102707:
					{
						return ValueType.TObject;
					}
					
					
					case 161311390:
					{
						return ValueType.TBool;
					}
					
					
					case 733906088:
					{
						return ValueType.TFloat;
					}
					
					
					case 935178491:
					{
						return ValueType.TInt;
					}
					
					
					case 294683899:
					{
						return ValueType.TNull;
					}
					
					
					case 1744813180:
					{
						return ValueType.constructs;
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
					case 194531701:
					{
						return ValueType.TEnum(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 1904228164:
					{
						return ValueType.TClass(((haxe.lang.Class) (dynargs[0]) ));
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
			baseArr.push("TUnknown");
			baseArr.push("TEnum");
			baseArr.push("TClass");
			baseArr.push("TFunction");
			baseArr.push("TObject");
			baseArr.push("TBool");
			baseArr.push("TFloat");
			baseArr.push("TInt");
			baseArr.push("TNull");
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
			return ((haxe.lang.Class) (( (( ValueType.__hx_class != default(haxe.lang.Class) )) ? (ValueType.__hx_class) : (ValueType.__hx_class = new haxe.lang.Class(new ValueType(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new ValueType(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new ValueType(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
		}
	}
	
	
}



public  class Type : haxe.lang.HxObject 
{
	public    Type() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   haxe.lang.Class getClass<T>(T o)
	{
		unchecked 
		{
			return default(haxe.lang.Class);
		}
	}
	
	
	public static   haxe.lang.Class getEnum(object o)
	{
		unchecked 
		{
			return default(haxe.lang.Class);
		}
	}
	
	
	public static   haxe.lang.Class getSuperClass(haxe.lang.Class c)
	{
		unchecked 
		{
			return default(haxe.lang.Class);
		}
	}
	
	
	public static   string getClassName(haxe.lang.Class c)
	{
		unchecked 
		{
			return default(string);
		}
	}
	
	
	public static   string getEnumName(haxe.lang.Class e)
	{
		unchecked 
		{
			return default(string);
		}
	}
	
	
	public static   haxe.lang.Class resolveClass(string name)
	{
		unchecked 
		{
			return default(haxe.lang.Class);
		}
	}
	
	
	public static   haxe.lang.Class resolveEnum(string name)
	{
		unchecked 
		{
			return default(haxe.lang.Class);
		}
	}
	
	
	public static   T createInstance<T>(haxe.lang.Class cl, Array args)
	{
		unchecked 
		{
			return default(T);
		}
	}
	
	
	public static   T createEmptyInstance<T>(haxe.lang.Class cl)
	{
		unchecked 
		{
			return default(T);
		}
	}
	
	
	public static   T createEnum<T>(haxe.lang.Class e, string constr, Array @params)
	{
		unchecked 
		{
			return default(T);
		}
	}
	
	
	public static   T createEnumIndex<T>(haxe.lang.Class e, int index, Array @params)
	{
		unchecked 
		{
			return default(T);
		}
	}
	
	
	public static   Array<object> describe(object t, bool fact)
	{
		unchecked 
		{
			return default(Array<object>);
		}
	}
	
	
	public static   Array<object> getInstanceFields(haxe.lang.Class c)
	{
		unchecked 
		{
			return default(Array<object>);
		}
	}
	
	
	public static   Array<object> getClassFields(haxe.lang.Class c)
	{
		unchecked 
		{
			return default(Array<object>);
		}
	}
	
	
	public static   Array<object> getEnumConstructs(haxe.lang.Class e)
	{
		unchecked 
		{
			return default(Array<object>);
		}
	}
	
	
	public static   ValueType @typeof(object v)
	{
		unchecked 
		{
			return default(ValueType);
		}
	}
	
	
	public static   bool enumEq<T>(T a, T b)
	{
		unchecked 
		{
			return true;
		}
	}
	
	
	public static   string enumConstructor(object e)
	{
		unchecked 
		{
			return (( haxe.lang.Runtime.getField(e, "tag", 5790298, true) + "" ));
		}
	}
	
	
	public static   Array enumParameters(object e)
	{
		unchecked 
		{
			return ( (( haxe.lang.Runtime.getField(e, "params", 1836776262, true) == default(object) )) ? (new Array<object>(new object[]{})) : (((Array<object>) (((Array) (haxe.lang.Runtime.getField(e, "params", 1836776262, true)) ).cast<object>()) )) );
		}
	}
	
	
	public static   int enumIndex(object e)
	{
		unchecked 
		{
			return ((int) (haxe.lang.Runtime.getField_f(e, "index", 1041537810, true)) );
		}
	}
	
	
	public static   Array<T> allEnums<T>(haxe.lang.Class e)
	{
		unchecked 
		{
			return default(Array<T>);
		}
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( Type.__hx_class != default(haxe.lang.Class) )) ? (Type.__hx_class) : (Type.__hx_class = new haxe.lang.Class(new Type(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    Type(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
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
					case 1768617329:
					{
						return new haxe.lang.Closure("allEnums", 1768617329, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 878910545:
					{
						return new haxe.lang.Closure("enumIndex", 878910545, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 2054707467:
					{
						return new haxe.lang.Closure("enumParameters", 2054707467, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1228056441:
					{
						return new haxe.lang.Closure("enumConstructor", 1228056441, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 97003981:
					{
						return new haxe.lang.Closure("enumEq", 97003981, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1463219793:
					{
						return new haxe.lang.Closure("typeof", 1463219793, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 57476627:
					{
						return new haxe.lang.Closure("getEnumConstructs", 57476627, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 2138425307:
					{
						return new haxe.lang.Closure("getClassFields", 2138425307, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1838624548:
					{
						return new haxe.lang.Closure("getInstanceFields", 1838624548, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 118272011:
					{
						return new haxe.lang.Closure("describe", 118272011, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1431819701:
					{
						return new haxe.lang.Closure("createEnumIndex", 1431819701, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1436822557:
					{
						return new haxe.lang.Closure("createEnum", 1436822557, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1317349030:
					{
						return new haxe.lang.Closure("createEmptyInstance", 1317349030, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 740007601:
					{
						return new haxe.lang.Closure("createInstance", 740007601, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1582403597:
					{
						return new haxe.lang.Closure("resolveEnum", 1582403597, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 14532012:
					{
						return new haxe.lang.Closure("resolveClass", 14532012, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1398464674:
					{
						return new haxe.lang.Closure("getEnumName", 1398464674, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 1804873517:
					{
						return new haxe.lang.Closure("getClassName", 1804873517, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 75105523:
					{
						return new haxe.lang.Closure("getSuperClass", 75105523, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 362355383:
					{
						return new haxe.lang.Closure("getEnum", 362355383, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
					}
					
					
					case 674203586:
					{
						return new haxe.lang.Closure("getClass", 674203586, ((haxe.lang.IHxObject) (Type.__hx_getClassStatic()) ));
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
					case 1768617329:
					{
						return Type.allEnums<object>(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 878910545:
					{
						return Type.enumIndex(dynargs[0]);
					}
					
					
					case 2054707467:
					{
						return Type.enumParameters(dynargs[0]);
					}
					
					
					case 1228056441:
					{
						return Type.enumConstructor(dynargs[0]);
					}
					
					
					case 97003981:
					{
						return Type.enumEq<object>(((object) (dynargs[0]) ), ((object) (dynargs[1]) ));
					}
					
					
					case 1463219793:
					{
						return Type.@typeof(dynargs[0]);
					}
					
					
					case 57476627:
					{
						return Type.getEnumConstructs(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 2138425307:
					{
						return Type.getClassFields(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 1838624548:
					{
						return Type.getInstanceFields(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 118272011:
					{
						return Type.describe(dynargs[0], ((bool) (dynargs[1]) ));
					}
					
					
					case 1431819701:
					{
						return Type.createEnumIndex<object>(((haxe.lang.Class) (dynargs[0]) ), haxe.lang.Runtime.toInt(dynargs[1]), ((Array) (dynargs[2]) ));
					}
					
					
					case 1436822557:
					{
						return Type.createEnum<object>(((haxe.lang.Class) (dynargs[0]) ), (( dynargs[1] + "" )), ((Array) (dynargs[2]) ));
					}
					
					
					case 1317349030:
					{
						return Type.createEmptyInstance<object>(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 740007601:
					{
						return Type.createInstance<object>(((haxe.lang.Class) (dynargs[0]) ), ((Array) (dynargs[1]) ));
					}
					
					
					case 1582403597:
					{
						return Type.resolveEnum((( dynargs[0] + "" )));
					}
					
					
					case 14532012:
					{
						return Type.resolveClass((( dynargs[0] + "" )));
					}
					
					
					case 1398464674:
					{
						return Type.getEnumName(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 1804873517:
					{
						return Type.getClassName(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 75105523:
					{
						return Type.getSuperClass(((haxe.lang.Class) (dynargs[0]) ));
					}
					
					
					case 362355383:
					{
						return Type.getEnum(dynargs[0]);
					}
					
					
					case 674203586:
					{
						return ((haxe.lang.Class) (Type.getClass<object>(((object) (dynargs[0]) ))) );
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
			baseArr.push("allEnums");
			baseArr.push("enumIndex");
			baseArr.push("enumParameters");
			baseArr.push("enumConstructor");
			baseArr.push("enumEq");
			baseArr.push("typeof");
			baseArr.push("getEnumConstructs");
			baseArr.push("getClassFields");
			baseArr.push("getInstanceFields");
			baseArr.push("describe");
			baseArr.push("createEnumIndex");
			baseArr.push("createEnum");
			baseArr.push("createEmptyInstance");
			baseArr.push("createInstance");
			baseArr.push("resolveEnum");
			baseArr.push("resolveClass");
			baseArr.push("getEnumName");
			baseArr.push("getClassName");
			baseArr.push("getSuperClass");
			baseArr.push("getEnum");
			baseArr.push("getClass");
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
			return ((haxe.lang.Class) (( (( Type.__hx_class != default(haxe.lang.Class) )) ? (Type.__hx_class) : (Type.__hx_class = new haxe.lang.Class(new Type(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Type(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Type();
		}
	}
	
	
}


