
namespace cs
{
	public  class Lib : haxe.lang.HxObject 
	{
		public    Lib() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static   T[] toNativeReadOnlyArray<T>(Array<T> arr, bool equalLengthRequired)
		{
			unchecked 
			{
				T[] native = arr.__a;
				if (( native.Length == arr.length )) 
				{
					return native;
				}
				 else 
				{
					return default(T[]);
				}
				
			}
		}
		
		
		public static   T @as<T>(object obj, haxe.lang.Class cl)
		{
			
			throw new haxe.lang.HaxeException("This function cannot be accessed at runtime");
	
		}
		
		
		public static   System.Type toNativeType(haxe.lang.Class cl)
		{
			unchecked 
			{
				return ((System.Type) (haxe.lang.Runtime.callField(cl, "nativeType", 337182705, default(Array))) );
			}
		}
		
		
		public static   System.Type getNativeType(object obj)
		{
			
			return obj.GetType();
	
		}
		
		
		public static   void wait()
		{
			System.Console.ReadLine();
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( cs.Lib.__hx_class != default(haxe.lang.Class) )) ? (cs.Lib.__hx_class) : (cs.Lib.__hx_class = new haxe.lang.Class(new cs.Lib(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    Lib(haxe.lang.EmptyObject empty) : base()
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
						case 1324505717:
						{
							return new haxe.lang.Closure("wait", 1324505717, ((haxe.lang.IHxObject) (cs.Lib.__hx_getClassStatic()) ));
						}
						
						
						case 1888181287:
						{
							return new haxe.lang.Closure("getNativeType", 1888181287, ((haxe.lang.IHxObject) (cs.Lib.__hx_getClassStatic()) ));
						}
						
						
						case 905457996:
						{
							return new haxe.lang.Closure("toNativeType", 905457996, ((haxe.lang.IHxObject) (cs.Lib.__hx_getClassStatic()) ));
						}
						
						
						case 21746:
						{
							return new haxe.lang.Closure("as", 21746, ((haxe.lang.IHxObject) (cs.Lib.__hx_getClassStatic()) ));
						}
						
						
						case 2004027781:
						{
							return new haxe.lang.Closure("toNativeReadOnlyArray", 2004027781, ((haxe.lang.IHxObject) (cs.Lib.__hx_getClassStatic()) ));
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
						case 1324505717:
						{
							cs.Lib.wait();
							return default(object);
						}
						
						
						case 1888181287:
						{
							return cs.Lib.getNativeType(dynargs[0]);
						}
						
						
						case 905457996:
						{
							return cs.Lib.toNativeType(((haxe.lang.Class) (dynargs[0]) ));
						}
						
						
						case 21746:
						{
							return cs.Lib.@as<object>(dynargs[0], ((haxe.lang.Class) (dynargs[1]) ));
						}
						
						
						case 2004027781:
						{
							return ((object[]) (cs.Lib.toNativeReadOnlyArray<object>(((Array<object>) (((Array) (dynargs[0]) ).cast<object>()) ), ((bool) (dynargs[1]) ))) );
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
				baseArr.push("wait");
				baseArr.push("getNativeType");
				baseArr.push("toNativeType");
				baseArr.push("as");
				baseArr.push("toNativeReadOnlyArray");
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
				return ((haxe.lang.Class) (( (( cs.Lib.__hx_class != default(haxe.lang.Class) )) ? (cs.Lib.__hx_class) : (cs.Lib.__hx_class = new haxe.lang.Class(new cs.Lib(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new cs.Lib(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new cs.Lib();
			}
		}
		
		
	}
}


