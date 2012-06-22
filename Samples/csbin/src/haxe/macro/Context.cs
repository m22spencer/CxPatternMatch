
namespace haxe.macro
{
	public  class Context : haxe.lang.HxObject 
	{
		public    Context() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.macro.Context.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.Context.__hx_class) : (haxe.macro.Context.__hx_class = new haxe.lang.Class(new haxe.macro.Context(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    Context(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
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
				return ((haxe.lang.Class) (( (( haxe.macro.Context.__hx_class != default(haxe.lang.Class) )) ? (haxe.macro.Context.__hx_class) : (haxe.macro.Context.__hx_class = new haxe.lang.Class(new haxe.macro.Context(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.macro.Context(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.macro.Context();
			}
		}
		
		
	}
}


