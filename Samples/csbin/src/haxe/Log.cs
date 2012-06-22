
namespace haxe
{
	public  class Log : haxe.lang.HxObject 
	{
		static Log() 
		{
			haxe.Log.trace = ( (( haxe.Fun_5016a25e.__hx_current != default(haxe.Fun_5016a25e) )) ? (haxe.Fun_5016a25e.__hx_current) : (haxe.Fun_5016a25e.__hx_current = ((haxe.Fun_5016a25e) (new haxe.Fun_5016a25e()) )) );
			haxe.Log.clear = ( (( haxe.Fun_d41d8cd9.__hx_current != default(haxe.Fun_d41d8cd9) )) ? (haxe.Fun_d41d8cd9.__hx_current) : (haxe.Fun_d41d8cd9.__hx_current = ((haxe.Fun_d41d8cd9) (new haxe.Fun_d41d8cd9()) )) );
		}
		public    Log() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static  haxe.lang.Function trace;
		
		public static  haxe.lang.Function clear;
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.Log.__hx_class != default(haxe.lang.Class) )) ? (haxe.Log.__hx_class) : (haxe.Log.__hx_class = new haxe.lang.Class(new haxe.Log(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    Log(haxe.lang.EmptyObject empty) : base()
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
						case 1213952397:
						{
							return haxe.Log.clear = ((haxe.lang.Function) (@value) );
						}
						
						
						case 371166853:
						{
							return haxe.Log.trace = ((haxe.lang.Function) (@value) );
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
						case 1213952397:
						{
							return haxe.Log.clear;
						}
						
						
						case 371166853:
						{
							return haxe.Log.trace;
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
		
		
		public override   void __hx_classFields(Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("clear");
				baseArr.push("trace");
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
				return ((haxe.lang.Class) (( (( haxe.Log.__hx_class != default(haxe.lang.Class) )) ? (haxe.Log.__hx_class) : (haxe.Log.__hx_class = new haxe.lang.Class(new haxe.Log(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.Log(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.Log();
			}
		}
		
		
	}
}



namespace haxe
{
	public  class Fun_5016a25e : haxe.lang.Function 
	{
		public    Fun_5016a25e() : base(2, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  haxe.Fun_5016a25e __hx_current;
		
		public override   object __hx_invoke2_o(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				object infos = ( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (((object) (__fn_float2) )) : (( (( __fn_dyn2 == default(object) )) ? (default(object)) : (((object) (__fn_dyn2) )) )) );
				object v = ( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
				string str = ( ( ( ( (( haxe.lang.Runtime.getField(infos, "fileName", 1648581351, true) + "" )) + ":" ) + ((int) (haxe.lang.Runtime.getField_f(infos, "lineNumber", 1981972957, true)) ) ) + ": " ) + (( v + "" )) );
				System.Console.WriteLine(str);
				return default(object);
			}
		}
		
		
	}
}



namespace haxe
{
	public  class Fun_d41d8cd9 : haxe.lang.Function 
	{
		public    Fun_d41d8cd9() : base(0, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  haxe.Fun_d41d8cd9 __hx_current;
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				{
				}
				
				return default(object);
			}
		}
		
		
	}
}


