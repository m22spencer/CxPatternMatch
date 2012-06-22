
public  class StringBuf : haxe.lang.HxObject 
{
	public    StringBuf() : base()
	{
		unchecked 
		{
			StringBuf.__hx_ctor(this);
		}
	}
	
	
	public static   void __hx_ctor(StringBuf __temp_me9)
	{
		unchecked 
		{
			__temp_me9.b = new System.Text.StringBuilder();
		}
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( StringBuf.__hx_class != default(haxe.lang.Class) )) ? (StringBuf.__hx_class) : (StringBuf.__hx_class = new haxe.lang.Class(new StringBuf(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    StringBuf(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	public   void @add(object x)
	{
		unchecked 
		{
			this.b.Append(x);
		}
	}
	
	
	public   void addSub(string s, int pos, haxe.lang.Null<int> len)
	{
		unchecked 
		{
			int l = ( (( len.@value == default(haxe.lang.Null<int>).@value )) ? (new haxe.lang.Null<int>(( s.Length - pos ), true)) : (len) ).@value;
			this.b.Append(s, pos, l);
		}
	}
	
	
	public   void addChar(int c)
	{
		unchecked 
		{
			this.b.Append(((char) (c) ));
		}
	}
	
	
	public   string toString()
	{
		unchecked 
		{
			return this.b.ToString();
		}
	}
	
	
	public  System.Text.StringBuilder b;
	
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
					case 98:
					{
						return this.b = ((System.Text.StringBuilder) (@value) );
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
					case 98:
					{
						return this.b;
					}
					
					
					case 946786476:
					{
						return new haxe.lang.Closure("toString", 946786476, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 2113708439:
					{
						return new haxe.lang.Closure("addChar", 2113708439, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 520665567:
					{
						return new haxe.lang.Closure("addSub", 520665567, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 4846113:
					{
						return new haxe.lang.Closure("add", 4846113, ((haxe.lang.IHxObject) (this) ));
					}
					
					
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
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 2113708439:
					{
						this.addChar(haxe.lang.Runtime.toInt(dynargs[0]));
						return default(object);
					}
					
					
					case 520665567:
					{
						this.addSub((( dynargs[0] + "" )), haxe.lang.Runtime.toInt(dynargs[1]), haxe.lang.Null<object>.ofDynamic<int>(dynargs[2]));
						return default(object);
					}
					
					
					case 4846113:
					{
						this.@add(dynargs[0]);
						return default(object);
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
			baseArr.push("b");
			if (isInstanceFields) 
			{
				baseArr.push("toString");
				baseArr.push("addChar");
				baseArr.push("addSub");
				baseArr.push("add");
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
			return ((haxe.lang.Class) (( (( StringBuf.__hx_class != default(haxe.lang.Class) )) ? (StringBuf.__hx_class) : (StringBuf.__hx_class = new haxe.lang.Class(new StringBuf(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new StringBuf(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new StringBuf();
		}
	}
	
	
	public override string ToString()
	{
		return this.toString();
	}
	
	
}


