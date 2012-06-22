
public sealed class Array<T> : haxe.lang.HxObject, Array 
{
		public Array(T[] native)	{		this.__a = native;		this.length = native.Length;	}public    Array() : base()
	{
		unchecked 
		{
			Array<object>.__hx_ctor<T>(this);
		}
	}
	
	
	public static   void __hx_ctor<T2>(Array<T2> __temp_me4)
	{
		unchecked 
		{
			__temp_me4.length = 0;
			__temp_me4.__a = new T2[0];
		}
	}
	
	
	public static   Array<X> ofNative<X>(X[] native)
	{
					return new Array<X>(native);	
	}
	
	
	public static   Array<Y> alloc<Y>(int size)
	{
					return new Array<Y>(new Y[size]);	
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( Array<object>.__hx_class != default(haxe.lang.Class) )) ? (Array<object>.__hx_class) : (Array<object>.__hx_class = new haxe.lang.Class(new Array<object>(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    Array(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	   object Array.cast<T1>()
	{
		unchecked 
		{
			if (( typeof(T) == typeof(T1) )) 
			{
				return this;
			}
			
			Array<T1> new_me = new Array<T1>(haxe.lang.EmptyObject.EMPTY);
			{
				object __temp_iterator28 = Reflect.fields(this).iterator();
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator28, "hasNext", 407283053, default(Array))) ))
				{
					string field = (( haxe.lang.Runtime.callField(__temp_iterator28, "next", 1224901875, default(Array)) + "" ));
					switch (field)
					{
						case "__a":
						{
							{
								T1[] __temp_new_arr1 = new T1[this.__a.Length];
								int __temp_i2 = -1;
								while ((  ++ __temp_i2 < this.__a.Length ))
								{
									object __temp_obj3 = ((object) (this.__a[__temp_i2]) );
									if ( ! (( __temp_obj3 == default(T[]) )) ) 
									{
										__temp_new_arr1[__temp_i2] = ((T1) (__temp_obj3) );
									}
									
								}
								
								new_me.__a = __temp_new_arr1;
							}
							
							break;
						}
						
						
						default:
						{
							Reflect.setField(new_me, field, ((object) (Reflect.field(this, field)) ));
							break;
						}
						
					}
					
				}
				
			}
			
			return new_me;
		}
	}
	
	
	public  int length;
	
	public  T[] __a;
	
	public   Array<T> concat(Array<T> a)
	{
		unchecked 
		{
			int len = ( this.length + a.length );
			T[] retarr = new T[len];
			System.Array.Copy(this.__a, 0, retarr, 0, this.length);
			System.Array.Copy(a.__a, 0, retarr, this.length, a.length);
			return Array<object>.ofNative<T>(retarr);
		}
	}
	
	
	public   void concatNative(T[] a)
	{
		unchecked 
		{
			T[] __a = this.__a;
			int len = ( this.length + a.Length );
			if (( __a.Length >= len )) 
			{
				System.Array.Copy(a, 0, __a, this.length, this.length);
			}
			 else 
			{
				T[] newarr = new T[len];
				System.Array.Copy(__a, 0, newarr, 0, this.length);
				System.Array.Copy(a, 0, newarr, this.length, a.Length);
				this.__a = newarr;
			}
			
			this.length = len;
		}
	}
	
	
	public   string @join(string sep)
	{
		unchecked 
		{
			StringBuf buf = new StringBuf();
			int i = -1;
			bool first = true;
			int length = this.length;
			while ((  ++ i < length ))
			{
				if (first) 
				{
					first = false;
				}
				 else 
				{
					buf.b.Append(sep);
				}
				
				buf.b.Append(this.__a[i]);
			}
			
			return buf.b.ToString();
		}
	}
	
	
	public   haxe.lang.Null<T> pop()
	{
		unchecked 
		{
			T[] __a = this.__a;
			int length = this.length;
			if (( length > 0 )) 
			{
				T val = __a[ -- length];
				__a[length] = default(T);
				this.length = length;
				return new haxe.lang.Null<T>(val, true);
			}
			 else 
			{
				return default(haxe.lang.Null<T>);
			}
			
		}
	}
	
	
	public   int push(T x)
	{
		unchecked 
		{
			if (( this.length >= this.__a.Length )) 
			{
				int newLen = ( (( this.length << 1 )) + 1 );
				T[] newarr = new T[newLen];
				this.__a.CopyTo(newarr, 0);
				this.__a = newarr;
			}
			
			this.__a[this.length] = x;
			return this.length++;
		}
	}
	
	
	public   void reverse()
	{
		unchecked 
		{
			int i = 0;
			int l = this.length;
			T[] a = this.__a;
			int half = ( l >> 1 );
			l -= 1;
			while (( i < half ))
			{
				T tmp = a[i];
				a[i] = a[( l - i )];
				a[( l - i )] = tmp;
				i += 1;
			}
			
		}
	}
	
	
	public   haxe.lang.Null<T> shift()
	{
		unchecked 
		{
			int l = this.length;
			if (( l == 0 )) 
			{
				return default(haxe.lang.Null<T>);
			}
			
			T[] a = this.__a;
			T x = a[0];
			l -= 1;
			System.Array.Copy(a, 1, a, 0, ( this.length - 1 ));
			a[l] = default(T);
			this.length = l;
			return new haxe.lang.Null<T>(x, true);
		}
	}
	
	
	public   Array<T> slice(int pos, haxe.lang.Null<int> end)
	{
		unchecked 
		{
			if (( pos < 0 )) 
			{
				pos = ( this.length + pos );
				if (( pos < 0 )) 
				{
					pos = 0;
				}
				
			}
			
			if (( end.@value == default(haxe.lang.Null<int>).@value )) 
			{
				end = new haxe.lang.Null<int>(new haxe.lang.Null<int>(this.length, true).@value, true);
			}
			 else 
			{
				if (( end.@value < 0 )) 
				{
					end = new haxe.lang.Null<int>(new haxe.lang.Null<int>(( this.length + end.@value ), true).@value, true);
				}
				
			}
			
			if (( end.@value > this.length )) 
			{
				end = new haxe.lang.Null<int>(new haxe.lang.Null<int>(this.length, true).@value, true);
			}
			
			int len = ( end.@value - pos );
			if (( len < 0 )) 
			{
				return new Array<T>();
			}
			
			T[] newarr = new T[len];
			System.Array.Copy(this.__a, pos, newarr, 0, len);
			return Array<object>.ofNative<T>(newarr);
		}
	}
	
	
	public   void sort(haxe.lang.Function f)
	{
		unchecked 
		{
			if (( this.length == 0 )) 
			{
				return ;
			}
			
			this.quicksort(0, ( this.length - 1 ), f);
		}
	}
	
	
	public   void quicksort(int lo, int hi, haxe.lang.Function f)
	{
		unchecked 
		{
			T[] buf = this.__a;
			int i = lo;
			int j = hi;
			T p = buf[( ( i + j ) >> 1 )];
			while (( i <= j ))
			{
				while (( ((int) (f.__hx_invoke2_f(default(double), default(double), buf[i], p)) ) < 0 ))
				{
					i++;
				}
				
				while (( ((int) (f.__hx_invoke2_f(default(double), default(double), buf[j], p)) ) > 0 ))
				{
					j--;
				}
				
				if (( i <= j )) 
				{
					T t = buf[i];
					buf[i++] = buf[j];
					buf[j--] = t;
				}
				
			}
			
			if (( lo < j )) 
			{
				this.quicksort(lo, j, f);
			}
			
			if (( i < hi )) 
			{
				this.quicksort(i, hi, f);
			}
			
		}
	}
	
	
	public   Array<T> splice(int pos, int len)
	{
		unchecked 
		{
			if (( len < 0 )) 
			{
				return new Array<T>();
			}
			
			if (( pos < 0 )) 
			{
				pos = ( this.length + pos );
				if (( pos < 0 )) 
				{
					pos = 0;
				}
				
			}
			
			if (( pos > this.length )) 
			{
				pos = 0;
				len = 0;
			}
			 else 
			{
				if (( ( pos + len ) > this.length )) 
				{
					len = ( this.length - pos );
					if (( len < 0 )) 
					{
						len = 0;
					}
					
				}
				
			}
			
			T[] a = this.__a;
			T[] ret = new T[len];
			System.Array.Copy(a, pos, ret, 0, len);
			Array<T> ret1 = Array<object>.ofNative<T>(ret);
			int end = ( pos + len );
			System.Array.Copy(a, end, a, pos, ( this.length - end ));
			this.length -= len;
			while ((  -- len >= 0 ))
			{
				a[( this.length + len )] = default(T);
			}
			
			return ret1;
		}
	}
	
	
	public   void spliceVoid(int pos, int len)
	{
		unchecked 
		{
			if (( len < 0 )) 
			{
				return ;
			}
			
			if (( pos < 0 )) 
			{
				pos = ( this.length + pos );
				if (( pos < 0 )) 
				{
					pos = 0;
				}
				
			}
			
			if (( pos > this.length )) 
			{
				pos = 0;
				len = 0;
			}
			 else 
			{
				if (( ( pos + len ) > this.length )) 
				{
					len = ( this.length - pos );
					if (( len < 0 )) 
					{
						len = 0;
					}
					
				}
				
			}
			
			T[] a = this.__a;
			int end = ( pos + len );
			System.Array.Copy(a, end, a, pos, ( this.length - end ));
			this.length -= len;
			while ((  -- len >= 0 ))
			{
				a[( this.length + len )] = default(T);
			}
			
		}
	}
	
	
	public   string toString()
	{
		unchecked 
		{
			StringBuf ret = new StringBuf();
			T[] a = this.__a;
			ret.b.Append("[");
			bool first = true;
			{
				int _g1 = 0;
				int _g = this.length;
				while (( _g1 < _g ))
				{
					int i = _g1++;
					if (first) 
					{
						first = false;
					}
					 else 
					{
						ret.b.Append(",");
					}
					
					ret.b.Append(a[i]);
				}
				
			}
			
			ret.b.Append("]");
			return ret.b.ToString();
		}
	}
	
	
	public   void unshift(T x)
	{
		unchecked 
		{
			T[] __a = this.__a;
			int length = this.length;
			if (( length >= __a.Length )) 
			{
				int newLen = ( (( length << 1 )) + 1 );
				T[] newarr = new T[newLen];
				System.Array.Copy(__a, 0, newarr, 1, length);
				this.__a = newarr;
			}
			 else 
			{
				System.Array.Copy(__a, 0, __a, 1, length);
			}
			
			this.__a[0] = x;
			 ++ this.length;
		}
	}
	
	
	public   void insert(int pos, T x)
	{
		unchecked 
		{
			int l = this.length;
			if (( pos < 0 )) 
			{
				pos = ( l + pos );
				if (( pos < 0 )) 
				{
					pos = 0;
				}
				
			}
			
			if (( pos >= l )) 
			{
				this.push(x);
				return ;
			}
			 else 
			{
				if (( pos == 0 )) 
				{
					this.unshift(x);
					return ;
				}
				
			}
			
			if (( l >= this.__a.Length )) 
			{
				int newLen = ( (( this.length << 1 )) + 1 );
				T[] newarr = new T[newLen];
				System.Array.Copy(this.__a, 0, newarr, 0, pos);
				newarr[pos] = x;
				System.Array.Copy(this.__a, pos, newarr, ( pos + 1 ), ( l - pos ));
				this.__a = newarr;
				 ++ this.length;
			}
			 else 
			{
				T[] __a = this.__a;
				System.Array.Copy(__a, pos, __a, ( pos + 1 ), ( l - pos ));
				System.Array.Copy(__a, 0, __a, 0, pos);
				__a[pos] = x;
				 ++ this.length;
			}
			
		}
	}
	
	
	public   bool @remove(T x)
	{
		unchecked 
		{
			T[] __a = this.__a;
			int i = -1;
			int length = this.length;
			while ((  ++ i < length ))
			{
				if (haxe.lang.Runtime.eq(__a[i], x)) 
				{
					System.Array.Copy(__a, ( i + 1 ), __a, i, ( ( length - i ) - 1 ));
					__a[ -- this.length] = default(T);
					return true;
				}
				
			}
			
			return false;
		}
	}
	
	
	public   Array<T> copy()
	{
		unchecked 
		{
			int len = this.length;
			T[] __a = this.__a;
			T[] newarr = new T[len];
			System.Array.Copy(__a, 0, newarr, 0, len);
			return Array<object>.ofNative<T>(newarr);
		}
	}
	
	
	public   object iterator()
	{
		unchecked 
		{
			Array<object> me = new Array<object>(new object[]{this});
			Array<int> i = new Array<int>(new int[]{0});
			Array<int> len = new Array<int>(new int[]{this.length});
			return new haxe.lang.DynamicObject(new Array<int>(new int[]{407283053, 1224901875}), new Array<object>(new object[]{new Fun_c51ebdb7(i, len), new Fun_ecc468bf<T>(me, i)}), new Array<int>(new int[]{}), new Array<double>(new double[]{}));
		}
	}
	
	
	public   T __get(int idx)
	{
		unchecked 
		{
			T[] __a = this.__a;
			uint idx1 = ((uint) (idx) );
			if (( idx1 > __a.Length )) 
			{
				return default(T);
			}
			
			return __a[idx1];
		}
	}
	
	
	public   T __set(int idx, T v)
	{
		unchecked 
		{
			uint idx1 = ((uint) (idx) );
			T[] __a = this.__a;
			if (( idx1 >= __a.Length )) 
			{
				T[] newArr = new T[( idx1 + 1 )];
				__a.CopyTo(newArr, 0);
				this.__a = __a = newArr;
				this.length = ((int) (( idx1 + 1 )) );
			}
			
			return __a[idx1] = v;
		}
	}
	
	
	public   T __unsafe_get(int idx)
	{
		unchecked 
		{
			return this.__a[idx];
		}
	}
	
	
	public   T __unsafe_set(int idx, T val)
	{
		unchecked 
		{
			return this.__a[idx] = val;
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
					case 4745537:
					{
						return this.__a = ((T[]) (@value) );
					}
					
					
					case 520590566:
					{
						return this.length = haxe.lang.Runtime.toInt(@value);
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
					case 563324021:
					{
						return new haxe.lang.Closure("alloc", 563324021, ((haxe.lang.IHxObject) (Array<object>.__hx_getClassStatic()) ));
					}
					
					
					case 891161102:
					{
						return new haxe.lang.Closure("ofNative", 891161102, ((haxe.lang.IHxObject) (Array<object>.__hx_getClassStatic()) ));
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
					case 1621420777:
					{
						return new haxe.lang.Closure("__unsafe_set", 1621420777, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1620824029:
					{
						return new haxe.lang.Closure("__unsafe_get", 1620824029, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1916009602:
					{
						return new haxe.lang.Closure("__set", 1916009602, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1915412854:
					{
						return new haxe.lang.Closure("__get", 1915412854, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 328878574:
					{
						return new haxe.lang.Closure("iterator", 328878574, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1103412149:
					{
						return new haxe.lang.Closure("copy", 1103412149, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 76061764:
					{
						return new haxe.lang.Closure("remove", 76061764, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 501039929:
					{
						return new haxe.lang.Closure("insert", 501039929, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 2025055113:
					{
						return new haxe.lang.Closure("unshift", 2025055113, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 946786476:
					{
						return new haxe.lang.Closure("toString", 946786476, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1352786672:
					{
						return new haxe.lang.Closure("spliceVoid", 1352786672, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1067353468:
					{
						return new haxe.lang.Closure("splice", 1067353468, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1282943179:
					{
						return new haxe.lang.Closure("quicksort", 1282943179, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1280845662:
					{
						return new haxe.lang.Closure("sort", 1280845662, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 2127021138:
					{
						return new haxe.lang.Closure("slice", 2127021138, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 2082663554:
					{
						return new haxe.lang.Closure("shift", 2082663554, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 452737314:
					{
						return new haxe.lang.Closure("reverse", 452737314, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1247875546:
					{
						return new haxe.lang.Closure("push", 1247875546, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 5594513:
					{
						return new haxe.lang.Closure("pop", 5594513, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1181037546:
					{
						return new haxe.lang.Closure("join", 1181037546, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1532710347:
					{
						return new haxe.lang.Closure("concatNative", 1532710347, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1204816148:
					{
						return new haxe.lang.Closure("concat", 1204816148, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 4745537:
					{
						return this.__a;
					}
					
					
					case 520590566:
					{
						return this.length;
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
					case 563324021:
					{
						return Array<object>.alloc<object>(haxe.lang.Runtime.toInt(dynargs[0]));
					}
					
					
					case 891161102:
					{
						return Array<object>.ofNative<object>(((object[]) (dynargs[0]) ));
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
					case 1621420777:
					{
						return this.__unsafe_set(haxe.lang.Runtime.toInt(dynargs[0]), ((T) (dynargs[1]) ));
					}
					
					
					case 1620824029:
					{
						return this.__unsafe_get(haxe.lang.Runtime.toInt(dynargs[0]));
					}
					
					
					case 1916009602:
					{
						return this.__set(haxe.lang.Runtime.toInt(dynargs[0]), ((T) (dynargs[1]) ));
					}
					
					
					case 1915412854:
					{
						return this.__get(haxe.lang.Runtime.toInt(dynargs[0]));
					}
					
					
					case 328878574:
					{
						return this.iterator();
					}
					
					
					case 1103412149:
					{
						return this.copy();
					}
					
					
					case 76061764:
					{
						return this.@remove(((T) (dynargs[0]) ));
					}
					
					
					case 501039929:
					{
						this.insert(haxe.lang.Runtime.toInt(dynargs[0]), ((T) (dynargs[1]) ));
						return default(object);
					}
					
					
					case 2025055113:
					{
						this.unshift(((T) (dynargs[0]) ));
						return default(object);
					}
					
					
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 1352786672:
					{
						this.spliceVoid(haxe.lang.Runtime.toInt(dynargs[0]), haxe.lang.Runtime.toInt(dynargs[1]));
						return default(object);
					}
					
					
					case 1067353468:
					{
						return this.splice(haxe.lang.Runtime.toInt(dynargs[0]), haxe.lang.Runtime.toInt(dynargs[1]));
					}
					
					
					case 1282943179:
					{
						this.quicksort(haxe.lang.Runtime.toInt(dynargs[0]), haxe.lang.Runtime.toInt(dynargs[1]), ((haxe.lang.Function) (dynargs[2]) ));
						return default(object);
					}
					
					
					case 1280845662:
					{
						this.sort(((haxe.lang.Function) (dynargs[0]) ));
						return default(object);
					}
					
					
					case 2127021138:
					{
						return this.slice(haxe.lang.Runtime.toInt(dynargs[0]), haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 2082663554:
					{
						return (this.shift()).toDynamic();
					}
					
					
					case 452737314:
					{
						this.reverse();
						return default(object);
					}
					
					
					case 1247875546:
					{
						return this.push(((T) (dynargs[0]) ));
					}
					
					
					case 5594513:
					{
						return (this.pop()).toDynamic();
					}
					
					
					case 1181037546:
					{
						return this.@join((( dynargs[0] + "" )));
					}
					
					
					case 1532710347:
					{
						this.concatNative(((T[]) (dynargs[0]) ));
						return default(object);
					}
					
					
					case 1204816148:
					{
						return this.concat(((Array<T>) (((Array) (dynargs[0]) ).cast<T>()) ));
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
			baseArr.push("alloc");
			baseArr.push("ofNative");
		}
	}
	
	
	public override   void __hx_getFields(Array<object> baseArr, bool isInstanceFields)
	{
		unchecked 
		{
			baseArr.push("__a");
			baseArr.push("length");
			if (isInstanceFields) 
			{
				baseArr.push("__unsafe_set");
				baseArr.push("__unsafe_get");
				baseArr.push("__set");
				baseArr.push("__get");
				baseArr.push("iterator");
				baseArr.push("copy");
				baseArr.push("remove");
				baseArr.push("insert");
				baseArr.push("unshift");
				baseArr.push("toString");
				baseArr.push("spliceVoid");
				baseArr.push("splice");
				baseArr.push("quicksort");
				baseArr.push("sort");
				baseArr.push("slice");
				baseArr.push("shift");
				baseArr.push("reverse");
				baseArr.push("push");
				baseArr.push("pop");
				baseArr.push("join");
				baseArr.push("concatNative");
				baseArr.push("concat");
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
			return ((haxe.lang.Class) (( (( Array<object>.__hx_class != default(haxe.lang.Class) )) ? (Array<object>.__hx_class) : (Array<object>.__hx_class = new haxe.lang.Class(new Array<object>(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Array<object>(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Array<object>();
		}
	}
	
	
	object Array.this[int key]
	{
		get
		{
			return ((object) this.__get(key));
		}
		set
		{
			this.__set(key, (T) value);
		}
	}
	
	
	public T this[int key]
	{
		get
		{
			return this.__get(key);
		}
		set
		{
			this.__set(key, value);
		}
	}
	
	
	public override string ToString()
	{
		return this.toString();
	}
	
	
}



public  class Fun_c51ebdb7 : haxe.lang.Function 
{
	public    Fun_c51ebdb7(Array<int> i, Array<int> len) : base(0, 0)
	{
		unchecked 
		{
			this.i = i;
			this.len = len;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			return ( this.i[0] < this.len[0] );
		}
	}
	
	
	public  Array<int> i;
	
	public  Array<int> len;
	
}



public  class Fun_ecc468bf<T> : haxe.lang.Function 
{
	public    Fun_ecc468bf(Array<object> me, Array<int> i) : base(0, 0)
	{
		unchecked 
		{
			this.me = me;
			this.i = i;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			return ((Array<T>) (((Array) (this.me[0]) ).cast<T>()) ).__a[this.i[0]++];
		}
	}
	
	
	public  Array<object> me;
	
	public  Array<int> i;
	
}



public  interface Array : haxe.lang.IHxObject 
{
	   object cast<T1>();
	
	object this[int key]
	{
		get;
		set;
	}
	
	
}


