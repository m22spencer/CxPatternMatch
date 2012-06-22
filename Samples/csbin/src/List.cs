
public  class List<T> : haxe.lang.HxObject, List 
{
	public    List() : base()
	{
		unchecked 
		{
			List<object>.__hx_ctor<T>(this);
		}
	}
	
	
	public static   void __hx_ctor<T2>(List<T2> __temp_me7)
	{
		unchecked 
		{
			__temp_me7.length = 0;
		}
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( List<object>.__hx_class != default(haxe.lang.Class) )) ? (List<object>.__hx_class) : (List<object>.__hx_class = new haxe.lang.Class(new List<object>(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    List(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	   object List.cast<T1>()
	{
		unchecked 
		{
			if (( typeof(T) == typeof(T1) )) 
			{
				return this;
			}
			
			List<T1> new_me = new List<T1>(haxe.lang.EmptyObject.EMPTY);
			{
				object __temp_iterator47 = Reflect.fields(this).iterator();
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator47, "hasNext", 407283053, default(Array))) ))
				{
					string field = (( haxe.lang.Runtime.callField(__temp_iterator47, "next", 1224901875, default(Array)) + "" ));
					switch (field)
					{
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
	
	
	public  Array h;
	
	public  Array q;
	
	public  int length;
	
	public virtual   void @add(T item)
	{
		unchecked 
		{
			Array<T> x = new Array<T>(new T[]{item});
			if (( this.h == default(Array) )) 
			{
				this.h = x;
			}
			 else 
			{
				this.q[1] = x;
			}
			
			this.q = x;
			this.length++;
		}
	}
	
	
	public virtual   void push(T item)
	{
		unchecked 
		{
			Array x = new Array<object>(new object[]{item, this.h});
			this.h = x;
			if (( this.q == default(Array) )) 
			{
				this.q = x;
			}
			
			this.length++;
		}
	}
	
	
	public virtual   haxe.lang.Null<T> first()
	{
		unchecked 
		{
			return ( (( this.h == default(Array) )) ? (default(haxe.lang.Null<T>)) : (haxe.lang.Null<object>.ofDynamic<T>(this.h[0])) );
		}
	}
	
	
	public virtual   haxe.lang.Null<T> last()
	{
		unchecked 
		{
			return ( (( this.q == default(Array) )) ? (default(haxe.lang.Null<T>)) : (haxe.lang.Null<object>.ofDynamic<T>(this.q[0])) );
		}
	}
	
	
	public virtual   haxe.lang.Null<T> pop()
	{
		unchecked 
		{
			if (( this.h == default(Array) )) 
			{
				return default(haxe.lang.Null<T>);
			}
			
			haxe.lang.Null<T> x = haxe.lang.Null<object>.ofDynamic<T>(this.h[0]);
			this.h = ((Array) (this.h[1]) );
			if (( this.h == default(Array) )) 
			{
				this.q = default(Array);
			}
			
			this.length--;
			return x;
		}
	}
	
	
	public virtual   bool isEmpty()
	{
		unchecked 
		{
			return ( this.h == default(Array) );
		}
	}
	
	
	public virtual   void clear()
	{
		unchecked 
		{
			this.h = default(Array);
			this.q = default(Array);
			this.length = 0;
		}
	}
	
	
	public virtual   bool @remove(T v)
	{
		unchecked 
		{
			Array<object> prev = default(Array<object>);
			Array l = this.h;
			while (( l != default(Array) ))
			{
				if (haxe.lang.Runtime.eq(l[0], v)) 
				{
					if (( prev == default(Array<object>) )) 
					{
						this.h = ((Array) (l[1]) );
					}
					 else 
					{
						prev[1] = l[1];
					}
					
					if (( this.q == l )) 
					{
						this.q = prev;
					}
					
					this.length--;
					return true;
				}
				
				prev = ((Array<object>) (((Array) (l) ).cast<object>()) );
				l = ((Array) (l[1]) );
			}
			
			return false;
		}
	}
	
	
	public virtual   object iterator()
	{
		unchecked 
		{
			Array<object> h = new Array<object>(new object[]{this.h});
			return ((object) (new haxe.lang.DynamicObject(new Array<int>(new int[]{407283053, 1224901875}), new Array<object>(new object[]{new Fun_87d8391f(h), new Fun_124e07c9(h)}), new Array<int>(new int[]{}), new Array<double>(new double[]{}))) );
		}
	}
	
	
	public virtual   string toString()
	{
		unchecked 
		{
			StringBuf s = new StringBuf();
			bool first = true;
			Array l = this.h;
			s.b.Append("{");
			while (( l != default(Array) ))
			{
				if (first) 
				{
					first = false;
				}
				 else 
				{
					s.b.Append(", ");
				}
				
				s.b.Append((( l[0] + "" )));
				l = ((Array) (l[1]) );
			}
			
			s.b.Append("}");
			return s.b.ToString();
		}
	}
	
	
	public virtual   string @join(string sep)
	{
		unchecked 
		{
			StringBuf s = new StringBuf();
			bool first = true;
			Array l = this.h;
			while (( l != default(Array) ))
			{
				if (first) 
				{
					first = false;
				}
				 else 
				{
					s.b.Append(sep);
				}
				
				s.b.Append(l[0]);
				l = ((Array) (l[1]) );
			}
			
			return s.b.ToString();
		}
	}
	
	
	public virtual   List<T> filter(haxe.lang.Function f)
	{
		unchecked 
		{
			List<T> l2 = new List<T>();
			Array l = this.h;
			while (( l != default(Array) ))
			{
				T v = ((T) (l[0]) );
				l = ((Array) (l[1]) );
				if (((bool) (f.__hx_invoke1_o(default(double), v)) )) 
				{
					l2.@add(v);
				}
				
			}
			
			return l2;
		}
	}
	
	
	public virtual   List<X> map<X>(haxe.lang.Function f)
	{
		unchecked 
		{
			List<X> b = new List<X>();
			Array l = this.h;
			while (( l != default(Array) ))
			{
				T v = ((T) (l[0]) );
				l = ((Array) (l[1]) );
				b.@add(((X) (f.__hx_invoke1_o(default(double), v)) ));
			}
			
			return b;
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
					
					
					case 113:
					{
						return this.q = ((Array) (@value) );
					}
					
					
					case 104:
					{
						return this.h = ((Array) (@value) );
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
					case 5442204:
					{
						return new haxe.lang.Closure("map", 5442204, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 87367608:
					{
						return new haxe.lang.Closure("filter", 87367608, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1181037546:
					{
						return new haxe.lang.Closure("join", 1181037546, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 946786476:
					{
						return new haxe.lang.Closure("toString", 946786476, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 328878574:
					{
						return new haxe.lang.Closure("iterator", 328878574, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 76061764:
					{
						return new haxe.lang.Closure("remove", 76061764, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1213952397:
					{
						return new haxe.lang.Closure("clear", 1213952397, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 207609411:
					{
						return new haxe.lang.Closure("isEmpty", 207609411, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 5594513:
					{
						return new haxe.lang.Closure("pop", 5594513, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1202522710:
					{
						return new haxe.lang.Closure("last", 1202522710, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 10319920:
					{
						return new haxe.lang.Closure("first", 10319920, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1247875546:
					{
						return new haxe.lang.Closure("push", 1247875546, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 4846113:
					{
						return new haxe.lang.Closure("add", 4846113, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 520590566:
					{
						return this.length;
					}
					
					
					case 113:
					{
						return this.q;
					}
					
					
					case 104:
					{
						return this.h;
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
					case 5442204:
					{
						return this.map<object>(((haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 87367608:
					{
						return this.filter(((haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 1181037546:
					{
						return this.@join((( dynargs[0] + "" )));
					}
					
					
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 328878574:
					{
						return this.iterator();
					}
					
					
					case 76061764:
					{
						return this.@remove(((T) (dynargs[0]) ));
					}
					
					
					case 1213952397:
					{
						this.clear();
						return default(object);
					}
					
					
					case 207609411:
					{
						return this.isEmpty();
					}
					
					
					case 5594513:
					{
						return (this.pop()).toDynamic();
					}
					
					
					case 1202522710:
					{
						return (this.last()).toDynamic();
					}
					
					
					case 10319920:
					{
						return (this.first()).toDynamic();
					}
					
					
					case 1247875546:
					{
						this.push(((T) (dynargs[0]) ));
						return default(object);
					}
					
					
					case 4846113:
					{
						this.@add(((T) (dynargs[0]) ));
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
			baseArr.push("length");
			baseArr.push("q");
			baseArr.push("h");
			if (isInstanceFields) 
			{
				baseArr.push("map");
				baseArr.push("filter");
				baseArr.push("join");
				baseArr.push("toString");
				baseArr.push("iterator");
				baseArr.push("remove");
				baseArr.push("clear");
				baseArr.push("isEmpty");
				baseArr.push("pop");
				baseArr.push("last");
				baseArr.push("first");
				baseArr.push("push");
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
			return ((haxe.lang.Class) (( (( List<object>.__hx_class != default(haxe.lang.Class) )) ? (List<object>.__hx_class) : (List<object>.__hx_class = new haxe.lang.Class(new List<object>(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new List<object>(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new List<object>();
		}
	}
	
	
	public override string ToString()
	{
		return this.toString();
	}
	
	
}



public  class Fun_87d8391f : haxe.lang.Function 
{
	public    Fun_87d8391f(Array<object> h) : base(0, 0)
	{
		unchecked 
		{
			this.h = h;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			return ( ((Array) (this.h[0]) ) != default(Array) );
		}
	}
	
	
	public  Array<object> h;
	
}



public  class Fun_124e07c9 : haxe.lang.Function 
{
	public    Fun_124e07c9(Array<object> h) : base(0, 0)
	{
		unchecked 
		{
			this.h = h;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			if (( ((Array) (this.h[0]) ) == default(Array) )) 
			{
				return default(object);
			}
			
			object x = ((Array) (this.h[0]) )[0];
			this.h[0] = ((Array) (((Array) (this.h[0]) )[1]) );
			return x;
		}
	}
	
	
	public  Array<object> h;
	
}



public  interface List : haxe.lang.IHxObject 
{
	   object cast<T1>();
	
}


