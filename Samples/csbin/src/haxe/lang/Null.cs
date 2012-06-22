
namespace haxe.lang
{
	public  struct Null<T> 
	{
		public    Null(T v, bool hasValue)
		{
			
			if (! (v is System.ValueType))
			{
				if (v.Equals(default(T)))
				{
					hasValue = false;
				}
			}
			
			if (!v.Equals(default(T)))
			{
				hasValue = true;
			}
			
			this.@value = v;
			this.hasValue = hasValue;
	
		}
		
		
		public static   haxe.lang.Null<T1> ofDynamic<T1>(object obj)
		{
			unchecked 
			{
				if (( obj == default(object) )) 
				{
					return new haxe.lang.Null<T1>(default(T1), false);
				}
				 else 
				{
					return new haxe.lang.Null<T1>(((T1) (obj) ), true);
				}
				
			}
		}
		
		
		public readonly T @value;
		
		public readonly bool hasValue;
		
		public   object toDynamic()
		{
			
		if (this.hasValue)
			return value;
		return null;
	
		}
		
		
	}
}


