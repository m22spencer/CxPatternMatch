
public  class Reflect : haxe.lang.HxObject 
{
	public    Reflect() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   bool hasField(object o, string field)
	{
		
		if (o is haxe.lang.IHxObject)
		return ((haxe.lang.IHxObject) o).__hx_getField(field, haxe.lang.FieldLookup.hash(field), false, false, true) != haxe.lang.Runtime.undefined;
		
		return haxe.lang.Runtime.slowHasField(o, field);
	
	}
	
	
	public static   object field(object o, string field)
	{
		
		if (o is haxe.lang.IHxObject)
		return ((haxe.lang.IHxObject) o).__hx_getField(field, haxe.lang.FieldLookup.hash(field), false, false, false);
		
		return haxe.lang.Runtime.slowGetField(o, field, false);
	
	}
	
	
	public static   void setField(object o, string field, object @value)
	{
		
		if (o is haxe.lang.IHxObject)
			((haxe.lang.IHxObject) o).__hx_setField(field, haxe.lang.FieldLookup.hash(field), false, value);
		else
			haxe.lang.Runtime.slowSetField(o, field, value);
	
	}
	
	
	public static   object getProperty(object o, string field)
	{
		unchecked 
		{
			return default(object);
		}
	}
	
	
	public static   void setProperty(object o, string field, object @value)
	{
		unchecked 
		{
			{
			}
			
		}
	}
	
	
	public static   object callMethod(object o, object func, Array args)
	{
		
		return ((haxe.lang.Function) func).__hx_invokeDynamic(args);
	
	}
	
	
	public static   Array<object> fields(object o)
	{
		
		if (o is haxe.lang.IHxObject)
		{
			Array<object> ret = new Array<object>();
			((haxe.lang.IHxObject) o).__hx_getFields(ret, false);
			return ret;
		} else {
			Array<object> ret = new Array<object>();
			
			if (o is System.Type)
			{
				System.Type cl = (System.Type) o;
				
				foreach(System.Reflection.FieldInfo fi in cl.GetFields(System.Reflection.BindingFlags.Static))
				{
					ret.push(fi.Name);
				}
				
				string last = null;
				foreach(System.Reflection.MethodInfo mi in cl.GetMethods(System.Reflection.BindingFlags.Static))
				{
					string name = mi.Name;
					if (last != name)
					{
						ret.push(name);
						last = name;
					}
				}
			}
			
			return ret;
		}
	
	}
	
	
	public static   bool isFunction(object f)
	{
		
		return f is haxe.lang.Function;
	
	}
	
	
	public static   int compare<T>(T a, T b)
	{
		
		return haxe.lang.Runtime.compare(a, b);
	
	}
	
	
	public static   bool compareMethods(object f1, object f2)
	{
		
		if (f1 == f2) 
			return true;
		
		if (f1 is haxe.lang.Closure && f2 is haxe.lang.Closure)
		{
			haxe.lang.Closure f1c = (haxe.lang.Closure) f1;
			haxe.lang.Closure f2c = (haxe.lang.Closure) f2;
			
			return haxe.lang.Runtime.refEq(f1c.target, f2c.target) && f1c.field.Equals(f2c.field);
		} else if (f1 is haxe.lang.NativeMethodFunction && f2 is haxe.lang.NativeMethodFunction) {
			haxe.lang.NativeMethodFunction f1n = (haxe.lang.NativeMethodFunction) f1;
			haxe.lang.NativeMethodFunction f2n = (haxe.lang.NativeMethodFunction) f2;
			return haxe.lang.Runtime.refEq(f1n.obj, f2n.obj) && f1n.field.Equals(f2n.field);
		}
		
		return false;
	
	}
	
	
	public static   bool isObject(object v)
	{
		
		return v is haxe.lang.DynamicObject;
	
	}
	
	
	public static   bool deleteField(object o, string f)
	{
		
		return (o is haxe.lang.DynamicObject && ((haxe.lang.DynamicObject) o).__hx_deleteField(f, haxe.lang.FieldLookup.hash(f)));
	
	}
	
	
	public static   T copy<T>(T o)
	{
		unchecked 
		{
			object o2 = new haxe.lang.DynamicObject(new Array<int>(new int[]{}), new Array<object>(new object[]{}), new Array<int>(new int[]{}), new Array<double>(new double[]{}));
			{
				int _g = 0;
				Array<object> _g1 = Reflect.fields(o);
				while (( _g < _g1.length ))
				{
					string f = (( _g1[_g] + "" ));
					 ++ _g;
					Reflect.setField(o2, f, Reflect.field(o, f));
				}
				
			}
			
			return ((T) (o2) );
		}
	}
	
	
	public static   object makeVarArgs(haxe.lang.Function f)
	{
		unchecked 
		{
			return new haxe.lang.VarArgsFunction(f);
		}
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( Reflect.__hx_class != default(haxe.lang.Class) )) ? (Reflect.__hx_class) : (Reflect.__hx_class = new haxe.lang.Class(new Reflect(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    Reflect(haxe.lang.EmptyObject empty) : base()
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
					case 109625238:
					{
						return new haxe.lang.Closure("makeVarArgs", 109625238, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 1103412149:
					{
						return new haxe.lang.Closure("copy", 1103412149, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 277399695:
					{
						return new haxe.lang.Closure("deleteField", 277399695, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 1839798857:
					{
						return new haxe.lang.Closure("isObject", 1839798857, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 930851917:
					{
						return new haxe.lang.Closure("compareMethods", 930851917, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 57219237:
					{
						return new haxe.lang.Closure("compare", 57219237, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 251772194:
					{
						return new haxe.lang.Closure("isFunction", 251772194, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 9342585:
					{
						return new haxe.lang.Closure("fields", 9342585, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 881511967:
					{
						return new haxe.lang.Closure("callMethod", 881511967, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 1553535511:
					{
						return new haxe.lang.Closure("setProperty", 1553535511, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 1378618123:
					{
						return new haxe.lang.Closure("getProperty", 1378618123, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 247987640:
					{
						return new haxe.lang.Closure("setField", 247987640, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 9671866:
					{
						return new haxe.lang.Closure("field", 9671866, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
					}
					
					
					case 216784640:
					{
						return new haxe.lang.Closure("hasField", 216784640, ((haxe.lang.IHxObject) (Reflect.__hx_getClassStatic()) ));
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
					case 109625238:
					{
						return Reflect.makeVarArgs(((haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 1103412149:
					{
						return Reflect.copy<object>(((object) (dynargs[0]) ));
					}
					
					
					case 277399695:
					{
						return Reflect.deleteField(dynargs[0], (( dynargs[1] + "" )));
					}
					
					
					case 1839798857:
					{
						return Reflect.isObject(dynargs[0]);
					}
					
					
					case 930851917:
					{
						return Reflect.compareMethods(dynargs[0], dynargs[1]);
					}
					
					
					case 57219237:
					{
						return Reflect.compare<object>(((object) (dynargs[0]) ), ((object) (dynargs[1]) ));
					}
					
					
					case 251772194:
					{
						return Reflect.isFunction(dynargs[0]);
					}
					
					
					case 9342585:
					{
						return Reflect.fields(dynargs[0]);
					}
					
					
					case 881511967:
					{
						return Reflect.callMethod(dynargs[0], dynargs[1], ((Array) (dynargs[2]) ));
					}
					
					
					case 1553535511:
					{
						Reflect.setProperty(dynargs[0], (( dynargs[1] + "" )), dynargs[2]);
						return default(object);
					}
					
					
					case 1378618123:
					{
						return Reflect.getProperty(dynargs[0], (( dynargs[1] + "" )));
					}
					
					
					case 247987640:
					{
						Reflect.setField(dynargs[0], (( dynargs[1] + "" )), dynargs[2]);
						return default(object);
					}
					
					
					case 9671866:
					{
						return Reflect.field(dynargs[0], (( dynargs[1] + "" )));
					}
					
					
					case 216784640:
					{
						return Reflect.hasField(dynargs[0], (( dynargs[1] + "" )));
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
			baseArr.push("makeVarArgs");
			baseArr.push("copy");
			baseArr.push("deleteField");
			baseArr.push("isObject");
			baseArr.push("compareMethods");
			baseArr.push("compare");
			baseArr.push("isFunction");
			baseArr.push("fields");
			baseArr.push("callMethod");
			baseArr.push("setProperty");
			baseArr.push("getProperty");
			baseArr.push("setField");
			baseArr.push("field");
			baseArr.push("hasField");
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
			return ((haxe.lang.Class) (( (( Reflect.__hx_class != default(haxe.lang.Class) )) ? (Reflect.__hx_class) : (Reflect.__hx_class = new haxe.lang.Class(new Reflect(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Reflect(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Reflect();
		}
	}
	
	
}


