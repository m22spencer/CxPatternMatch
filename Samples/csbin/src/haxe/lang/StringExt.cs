
namespace haxe.lang
{
	public  class StringExt 
	{
		public static   string charAt(string me, int index)
		{
						if ( ((uint) index) >= me.Length)				return null;			else				return new string(me[index], 1);	
		}
		
		
		public static   haxe.lang.Null<int> charCodeAt(string me, int index)
		{
						if ( ((uint) index) >= me.Length)				return default(haxe.lang.Null<int>);			else				return new haxe.lang.Null<int>((int)me[index], true);	
		}
		
		
		public static   int indexOf(string me, string str, haxe.lang.Null<int> startIndex)
		{
						uint sIndex = (startIndex.hasValue) ? ((uint) startIndex.@value) : 0;			if (sIndex >= me.Length)				return -1;			return me.IndexOf(str, (int)sIndex);	
		}
		
		
		public static   int lastIndexOf(string me, string str, haxe.lang.Null<int> startIndex)
		{
						int sIndex = (startIndex.hasValue) ? (startIndex.@value) : (me.Length - 1);			if (sIndex > me.Length)				sIndex = me.Length - 1;			else if (sIndex < 0)				return -1;			return me.LastIndexOf(str, sIndex);	
		}
		
		
		public static   Array<object> split(string me, string delimiter)
		{
						string[] native = me.Split(new string[] { delimiter }, System.StringSplitOptions.None);			return new Array<object>(native);	
		}
		
		
		public static   string substr(string me, int pos, haxe.lang.Null<int> len)
		{
						int meLen = me.Length;			int targetLen = meLen;			if (len.hasValue)			{				targetLen = len.@value;				if (targetLen == 0)					return "";				if( pos != 0 && targetLen < 0 ){					return "";				}			}						if( pos < 0 ){				pos = meLen + pos;				if( pos < 0 ) pos = 0;			} else if( targetLen < 0 ){				targetLen = meLen + targetLen - pos;			}			if( pos + targetLen > meLen ){				targetLen = meLen - pos;			}			if ( pos < 0 || targetLen <= 0 ) return "";						return me.Substring(pos, targetLen);	
		}
		
		
		public static   string toLowerCase(string me)
		{
						return me.ToLower();	
		}
		
		
		public static   string toUpperCase(string me)
		{
						return me.ToUpper();	
		}
		
		
		public static   string toNativeString(string me)
		{
			unchecked 
			{
				return me;
			}
		}
		
		
		public static   string fromCharCode(int code)
		{
						return new string( (char) code, 1 );	
		}
		
		
	}
}



namespace haxe.lang
{
	public  class StringRefl : haxe.lang.HxObject 
	{
		public    StringRefl(string target) : base()
		{
			unchecked 
			{
				haxe.lang.StringRefl.__hx_ctor(this, target);
			}
		}
		
		
		public static   void __hx_ctor(haxe.lang.StringRefl __temp_me16, string target)
		{
			unchecked 
			{
				__temp_me16.target = target;
				__temp_me16.length = target.Length;
			}
		}
		
		
		public static   string fromCharCode(int code)
		{
			unchecked 
			{
				return new string(((char) (code) ), 1);
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.lang.StringRefl.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.StringRefl.__hx_class) : (haxe.lang.StringRefl.__hx_class = new haxe.lang.Class(new haxe.lang.StringRefl(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    StringRefl(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
		public  string target;
		
		public  int length;
		
		public virtual   string charAt(int index)
		{
			unchecked 
			{
				return haxe.lang.StringExt.charAt(this.target, index);
			}
		}
		
		
		public virtual   haxe.lang.Null<int> charCodeAt(int index)
		{
			unchecked 
			{
				return haxe.lang.StringExt.charCodeAt(this.target, index);
			}
		}
		
		
		public virtual   int indexOf(string str, haxe.lang.Null<int> __temp_startIndex17)
		{
			unchecked 
			{
				haxe.lang.Null<int> startIndex = ( (( __temp_startIndex17.@value == default(haxe.lang.Null<int>).@value )) ? (new haxe.lang.Null<int>(0, true)) : (new haxe.lang.Null<int>(__temp_startIndex17.@value, true)) );
				return haxe.lang.StringExt.indexOf(this.target, str, startIndex);
			}
		}
		
		
		public virtual   int lastIndexOf(string str, haxe.lang.Null<int> __temp_startIndex18)
		{
			unchecked 
			{
				haxe.lang.Null<int> startIndex = ( (( __temp_startIndex18.@value == default(haxe.lang.Null<int>).@value )) ? (new haxe.lang.Null<int>(-1, true)) : (new haxe.lang.Null<int>(__temp_startIndex18.@value, true)) );
				if (haxe.lang.Runtime.eq((startIndex).toDynamic(), -1)) 
				{
					startIndex = new haxe.lang.Null<int>(new haxe.lang.Null<int>(this.length, true).@value, true);
				}
				
				return haxe.lang.StringExt.lastIndexOf(this.target, str, startIndex);
			}
		}
		
		
		public virtual   Array<object> split(string delimiter)
		{
			unchecked 
			{
				return haxe.lang.StringExt.split(this.target, delimiter);
			}
		}
		
		
		public virtual   string substr(int pos, haxe.lang.Null<int> __temp_len19)
		{
			unchecked 
			{
				haxe.lang.Null<int> len = ( (( __temp_len19.@value == default(haxe.lang.Null<int>).@value )) ? (new haxe.lang.Null<int>(-1, true)) : (new haxe.lang.Null<int>(__temp_len19.@value, true)) );
				if (haxe.lang.Runtime.eq((len).toDynamic(), -1)) 
				{
					len = new haxe.lang.Null<int>(new haxe.lang.Null<int>(this.length, true).@value, true);
				}
				
				return haxe.lang.StringExt.substr(this.target, pos, len);
			}
		}
		
		
		public virtual   string toLowerCase()
		{
			unchecked 
			{
				return haxe.lang.StringExt.toLowerCase(this.target);
			}
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				return this.target;
			}
		}
		
		
		public virtual   string toUpperCase()
		{
			unchecked 
			{
				return haxe.lang.StringExt.toUpperCase(this.target);
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
						case 520590566:
						{
							return this.length = ((int) (@value) );
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
						case 520590566:
						{
							return this.length = haxe.lang.Runtime.toInt(@value);
						}
						
						
						case 116192081:
						{
							return this.target = (( @value + "" ));
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
						case 1010514605:
						{
							return new haxe.lang.Closure("fromCharCode", 1010514605, ((haxe.lang.IHxObject) (haxe.lang.StringRefl.__hx_getClassStatic()) ));
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
						case 956117047:
						{
							return new haxe.lang.Closure("toUpperCase", 956117047, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 946786476:
						{
							return new haxe.lang.Closure("toString", 946786476, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 946097238:
						{
							return new haxe.lang.Closure("toLowerCase", 946097238, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 436924209:
						{
							return new haxe.lang.Closure("substr", 436924209, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 24046298:
						{
							return new haxe.lang.Closure("split", 24046298, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 359333139:
						{
							return new haxe.lang.Closure("lastIndexOf", 359333139, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 1623148745:
						{
							return new haxe.lang.Closure("indexOf", 1623148745, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 894756598:
						{
							return new haxe.lang.Closure("charCodeAt", 894756598, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 930445673:
						{
							return new haxe.lang.Closure("charAt", 930445673, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 520590566:
						{
							return this.length;
						}
						
						
						case 116192081:
						{
							return this.target;
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
						case 520590566:
						{
							return this.length;
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
						case 1010514605:
						{
							return new string(((char) (haxe.lang.Runtime.toInt(dynargs[0])) ), 1);
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
						case 956117047:
						{
							return this.toUpperCase();
						}
						
						
						case 946786476:
						{
							return this.toString();
						}
						
						
						case 946097238:
						{
							return this.toLowerCase();
						}
						
						
						case 436924209:
						{
							return this.substr(haxe.lang.Runtime.toInt(dynargs[0]), haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
						}
						
						
						case 24046298:
						{
							return this.split((( dynargs[0] + "" )));
						}
						
						
						case 359333139:
						{
							return this.lastIndexOf((( dynargs[0] + "" )), haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
						}
						
						
						case 1623148745:
						{
							return this.indexOf((( dynargs[0] + "" )), haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
						}
						
						
						case 894756598:
						{
							return (this.charCodeAt(haxe.lang.Runtime.toInt(dynargs[0]))).toDynamic();
						}
						
						
						case 930445673:
						{
							return this.charAt(haxe.lang.Runtime.toInt(dynargs[0]));
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
				baseArr.push("fromCharCode");
			}
		}
		
		
		public override   void __hx_getFields(Array<object> baseArr, bool isInstanceFields)
		{
			unchecked 
			{
				baseArr.push("length");
				baseArr.push("target");
				if (isInstanceFields) 
				{
					baseArr.push("toUpperCase");
					baseArr.push("toString");
					baseArr.push("toLowerCase");
					baseArr.push("substr");
					baseArr.push("split");
					baseArr.push("lastIndexOf");
					baseArr.push("indexOf");
					baseArr.push("charCodeAt");
					baseArr.push("charAt");
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
				return ((haxe.lang.Class) (( (( haxe.lang.StringRefl.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.StringRefl.__hx_class) : (haxe.lang.StringRefl.__hx_class = new haxe.lang.Class(new haxe.lang.StringRefl(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.StringRefl(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.StringRefl((( arr[0] + "" )));
			}
		}
		
		
		public override string ToString()
		{
			return this.toString();
		}
		
		
	}
}


