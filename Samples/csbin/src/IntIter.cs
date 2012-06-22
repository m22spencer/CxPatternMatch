
public  class IntIter : haxe.lang.HxObject 
{
	public    IntIter(int min, int max) : base()
	{
		unchecked 
		{
			IntIter.__hx_ctor(this, min, max);
		}
	}
	
	
	public static   void __hx_ctor(IntIter __temp_me6, int min, int max)
	{
		unchecked 
		{
			__temp_me6.min = min;
			__temp_me6.max = max;
		}
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( IntIter.__hx_class != default(haxe.lang.Class) )) ? (IntIter.__hx_class) : (IntIter.__hx_class = new haxe.lang.Class(new IntIter(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    IntIter(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	public  int min;
	
	public  int max;
	
	public virtual   bool hasNext()
	{
		unchecked 
		{
			return ( this.min < this.max );
		}
	}
	
	
	public virtual   int next()
	{
		unchecked 
		{
			return this.min++;
		}
	}
	
	
	public override   double __hx_setField_f(string field, int hash, bool isStatic, double @value)
	{
		unchecked 
		{
			if (isStatic) 
			{
				switch (hash)
				{
					default:
					{
						return this.__hx_lookupSetField_f(field, hash, @value);
					}
					
				}
				
			}
			 else 
			{
				switch (hash)
				{
					case 5442212:
					{
						return this.max = ((int) (@value) );
					}
					
					
					case 5443986:
					{
						return this.min = ((int) (@value) );
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, isStatic, @value);
					}
					
				}
				
			}
			
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
					case 5442212:
					{
						return this.max = haxe.lang.Runtime.toInt(@value);
					}
					
					
					case 5443986:
					{
						return this.min = haxe.lang.Runtime.toInt(@value);
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
					case 1224901875:
					{
						return new haxe.lang.Closure("next", 1224901875, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 407283053:
					{
						return new haxe.lang.Closure("hasNext", 407283053, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 5442212:
					{
						return this.max;
					}
					
					
					case 5443986:
					{
						return this.min;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, isStatic, throwErrors, isCheck);
					}
					
				}
				
			}
			
		}
	}
	
	
	public override   double __hx_getField_f(string field, int hash, bool isStatic, bool throwErrors)
	{
		unchecked 
		{
			if (isStatic) 
			{
				switch (hash)
				{
					default:
					{
						return this.__hx_lookupField_f(field, hash, throwErrors);
					}
					
				}
				
			}
			 else 
			{
				switch (hash)
				{
					case 5442212:
					{
						return this.max;
					}
					
					
					case 5443986:
					{
						return this.min;
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, isStatic, throwErrors);
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
					case 1224901875:
					{
						return this.next();
					}
					
					
					case 407283053:
					{
						return this.hasNext();
					}
					
					
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
			{
			}
			
		}
	}
	
	
	public override   void __hx_getFields(Array<object> baseArr, bool isInstanceFields)
	{
		unchecked 
		{
			baseArr.push("max");
			baseArr.push("min");
			if (isInstanceFields) 
			{
				baseArr.push("next");
				baseArr.push("hasNext");
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
			return ((haxe.lang.Class) (( (( IntIter.__hx_class != default(haxe.lang.Class) )) ? (IntIter.__hx_class) : (IntIter.__hx_class = new haxe.lang.Class(new IntIter(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new IntIter(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new IntIter(haxe.lang.Runtime.toInt(arr[0]), haxe.lang.Runtime.toInt(arr[1]));
		}
	}
	
	
}


