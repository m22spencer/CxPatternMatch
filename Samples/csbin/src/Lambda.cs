
public  class Lambda : haxe.lang.HxObject 
{
	public    Lambda() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   Array<A> array<A>(object it)
	{
		unchecked 
		{
			Array<A> a = new Array<A>();
			{
				object __temp_iterator31 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator31, "hasNext", 407283053, default(Array))) ))
				{
					A i = ((A) (haxe.lang.Runtime.callField(__temp_iterator31, "next", 1224901875, default(Array))) );
					a.push(i);
				}
				
			}
			
			return a;
		}
	}
	
	
	public static   List<A> list<A>(object it)
	{
		unchecked 
		{
			List<A> l = new List<A>();
			{
				object __temp_iterator32 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator32, "hasNext", 407283053, default(Array))) ))
				{
					A i = ((A) (haxe.lang.Runtime.callField(__temp_iterator32, "next", 1224901875, default(Array))) );
					l.@add(i);
				}
				
			}
			
			return l;
		}
	}
	
	
	public static   List<B> map<A, B>(object it, haxe.lang.Function f)
	{
		unchecked 
		{
			List<B> l = new List<B>();
			{
				object __temp_iterator33 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator33, "hasNext", 407283053, default(Array))) ))
				{
					A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator33, "next", 1224901875, default(Array))) );
					l.@add(((B) (f.__hx_invoke1_o(default(double), x)) ));
				}
				
			}
			
			return l;
		}
	}
	
	
	public static   List<B> mapi<A, B>(object it, haxe.lang.Function f)
	{
		unchecked 
		{
			List<B> l = new List<B>();
			int i = 0;
			{
				object __temp_iterator34 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator34, "hasNext", 407283053, default(Array))) ))
				{
					A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator34, "next", 1224901875, default(Array))) );
					l.@add(((B) (f.__hx_invoke2_o(i++, default(double), haxe.lang.Runtime.undefined, x)) ));
				}
				
			}
			
			return l;
		}
	}
	
	
	public static   bool has<A>(object it, A elt, haxe.lang.Function cmp)
	{
		unchecked 
		{
			if (( cmp == default(haxe.lang.Function) )) 
			{
				{
					object __temp_iterator36 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
					while (((bool) (haxe.lang.Runtime.callField(__temp_iterator36, "hasNext", 407283053, default(Array))) ))
					{
						A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator36, "next", 1224901875, default(Array))) );
						if (haxe.lang.Runtime.eq(x, elt)) 
						{
							return true;
						}
						
					}
					
				}
				
			}
			 else 
			{
				{
					object __temp_iterator35 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
					while (((bool) (haxe.lang.Runtime.callField(__temp_iterator35, "hasNext", 407283053, default(Array))) ))
					{
						A x1 = ((A) (haxe.lang.Runtime.callField(__temp_iterator35, "next", 1224901875, default(Array))) );
						if (((bool) (cmp.__hx_invoke2_o(default(double), default(double), x1, elt)) )) 
						{
							return true;
						}
						
					}
					
				}
				
			}
			
			return false;
		}
	}
	
	
	public static   bool exists<A>(object it, haxe.lang.Function f)
	{
		unchecked 
		{
			{
				object __temp_iterator37 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator37, "hasNext", 407283053, default(Array))) ))
				{
					A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator37, "next", 1224901875, default(Array))) );
					if (((bool) (f.__hx_invoke1_o(default(double), x)) )) 
					{
						return true;
					}
					
				}
				
			}
			
			return false;
		}
	}
	
	
	public static   bool @foreach<A>(object it, haxe.lang.Function f)
	{
		unchecked 
		{
			{
				object __temp_iterator38 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator38, "hasNext", 407283053, default(Array))) ))
				{
					A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator38, "next", 1224901875, default(Array))) );
					if ( ! (((bool) (f.__hx_invoke1_o(default(double), x)) )) ) 
					{
						return false;
					}
					
				}
				
			}
			
			return true;
		}
	}
	
	
	public static   void iter<A>(object it, haxe.lang.Function f)
	{
		unchecked 
		{
			{
				object __temp_iterator39 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator39, "hasNext", 407283053, default(Array))) ))
				{
					A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator39, "next", 1224901875, default(Array))) );
					f.__hx_invoke1_o(default(double), x);
				}
				
			}
			
		}
	}
	
	
	public static   List<A> filter<A>(object it, haxe.lang.Function f)
	{
		unchecked 
		{
			List<A> l = new List<A>();
			{
				object __temp_iterator40 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator40, "hasNext", 407283053, default(Array))) ))
				{
					A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator40, "next", 1224901875, default(Array))) );
					if (((bool) (f.__hx_invoke1_o(default(double), x)) )) 
					{
						l.@add(x);
					}
					
				}
				
			}
			
			return l;
		}
	}
	
	
	public static   B fold<A, B>(object it, haxe.lang.Function f, B first)
	{
		unchecked 
		{
			{
				object __temp_iterator41 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator41, "hasNext", 407283053, default(Array))) ))
				{
					A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator41, "next", 1224901875, default(Array))) );
					first = ((B) (f.__hx_invoke2_o(default(double), default(double), x, first)) );
				}
				
			}
			
			return first;
		}
	}
	
	
	public static   int count<A>(object it, haxe.lang.Function pred)
	{
		unchecked 
		{
			int n = 0;
			if (( pred == default(haxe.lang.Function) )) 
			{
				{
					object __temp_iterator43 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
					while (((bool) (haxe.lang.Runtime.callField(__temp_iterator43, "hasNext", 407283053, default(Array))) ))
					{
						A _ = ((A) (haxe.lang.Runtime.callField(__temp_iterator43, "next", 1224901875, default(Array))) );
						n++;
					}
					
				}
				
			}
			 else 
			{
				{
					object __temp_iterator42 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
					while (((bool) (haxe.lang.Runtime.callField(__temp_iterator42, "hasNext", 407283053, default(Array))) ))
					{
						A x = ((A) (haxe.lang.Runtime.callField(__temp_iterator42, "next", 1224901875, default(Array))) );
						if (((bool) (pred.__hx_invoke1_o(default(double), x)) )) 
						{
							n++;
						}
						
					}
					
				}
				
			}
			
			return n;
		}
	}
	
	
	public static   bool empty(object it)
	{
		unchecked 
		{
			return  ! (((bool) (haxe.lang.Runtime.callField(((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) ), "hasNext", 407283053, default(Array))) )) ;
		}
	}
	
	
	public static   int indexOf<T>(object it, T v)
	{
		unchecked 
		{
			int i = 0;
			{
				object __temp_iterator44 = ((object) (haxe.lang.Runtime.callField(it, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator44, "hasNext", 407283053, default(Array))) ))
				{
					T v2 = ((T) (haxe.lang.Runtime.callField(__temp_iterator44, "next", 1224901875, default(Array))) );
					if (haxe.lang.Runtime.eq(v, v2)) 
					{
						return i;
					}
					
					i++;
				}
				
			}
			
			return -1;
		}
	}
	
	
	public static   List<T> concat<T>(object a, object b)
	{
		unchecked 
		{
			List<T> l = new List<T>();
			{
				object __temp_iterator45 = ((object) (haxe.lang.Runtime.callField(a, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator45, "hasNext", 407283053, default(Array))) ))
				{
					T x = ((T) (haxe.lang.Runtime.callField(__temp_iterator45, "next", 1224901875, default(Array))) );
					l.@add(x);
				}
				
			}
			
			{
				object __temp_iterator46 = ((object) (haxe.lang.Runtime.callField(b, "iterator", 328878574, default(Array))) );
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator46, "hasNext", 407283053, default(Array))) ))
				{
					T x1 = ((T) (haxe.lang.Runtime.callField(__temp_iterator46, "next", 1224901875, default(Array))) );
					l.@add(x1);
				}
				
			}
			
			return l;
		}
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( Lambda.__hx_class != default(haxe.lang.Class) )) ? (Lambda.__hx_class) : (Lambda.__hx_class = new haxe.lang.Class(new Lambda(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    Lambda(haxe.lang.EmptyObject empty) : base()
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
					case 1204816148:
					{
						return new haxe.lang.Closure("concat", 1204816148, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1623148745:
					{
						return new haxe.lang.Closure("indexOf", 1623148745, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1876572813:
					{
						return new haxe.lang.Closure("empty", 1876572813, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1248019663:
					{
						return new haxe.lang.Closure("count", 1248019663, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1136679937:
					{
						return new haxe.lang.Closure("fold", 1136679937, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 87367608:
					{
						return new haxe.lang.Closure("filter", 87367608, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1170195736:
					{
						return new haxe.lang.Closure("iter", 1170195736, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1508179338:
					{
						return new haxe.lang.Closure("foreach", 1508179338, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1071652316:
					{
						return new haxe.lang.Closure("exists", 1071652316, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 5193562:
					{
						return new haxe.lang.Closure("has", 5193562, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1213611597:
					{
						return new haxe.lang.Closure("mapi", 1213611597, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 5442204:
					{
						return new haxe.lang.Closure("map", 5442204, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 1202920542:
					{
						return new haxe.lang.Closure("list", 1202920542, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
					}
					
					
					case 630156697:
					{
						return new haxe.lang.Closure("array", 630156697, ((haxe.lang.IHxObject) (Lambda.__hx_getClassStatic()) ));
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
					case 1204816148:
					{
						return Lambda.concat<object>(((object) (dynargs[0]) ), ((object) (dynargs[1]) ));
					}
					
					
					case 1623148745:
					{
						return Lambda.indexOf<object>(((object) (dynargs[0]) ), ((object) (dynargs[1]) ));
					}
					
					
					case 1876572813:
					{
						return Lambda.empty(((object) (dynargs[0]) ));
					}
					
					
					case 1248019663:
					{
						return Lambda.count<object>(((object) (dynargs[0]) ), ((haxe.lang.Function) (dynargs[1]) ));
					}
					
					
					case 1136679937:
					{
						return Lambda.fold<object, object>(((object) (dynargs[0]) ), ((haxe.lang.Function) (dynargs[1]) ), ((object) (dynargs[2]) ));
					}
					
					
					case 87367608:
					{
						return Lambda.filter<object>(((object) (dynargs[0]) ), ((haxe.lang.Function) (dynargs[1]) ));
					}
					
					
					case 1170195736:
					{
						Lambda.iter<object>(((object) (dynargs[0]) ), ((haxe.lang.Function) (dynargs[1]) ));
						return default(object);
					}
					
					
					case 1508179338:
					{
						return Lambda.@foreach<object>(((object) (dynargs[0]) ), ((haxe.lang.Function) (dynargs[1]) ));
					}
					
					
					case 1071652316:
					{
						return Lambda.exists<object>(((object) (dynargs[0]) ), ((haxe.lang.Function) (dynargs[1]) ));
					}
					
					
					case 5193562:
					{
						return Lambda.has<object>(((object) (dynargs[0]) ), ((object) (dynargs[1]) ), ((haxe.lang.Function) (dynargs[2]) ));
					}
					
					
					case 1213611597:
					{
						return Lambda.mapi<object, object>(((object) (dynargs[0]) ), ((haxe.lang.Function) (dynargs[1]) ));
					}
					
					
					case 5442204:
					{
						return Lambda.map<object, object>(((object) (dynargs[0]) ), ((haxe.lang.Function) (dynargs[1]) ));
					}
					
					
					case 1202920542:
					{
						return Lambda.list<object>(((object) (dynargs[0]) ));
					}
					
					
					case 630156697:
					{
						return Lambda.array<object>(((object) (dynargs[0]) ));
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
			baseArr.push("concat");
			baseArr.push("indexOf");
			baseArr.push("empty");
			baseArr.push("count");
			baseArr.push("fold");
			baseArr.push("filter");
			baseArr.push("iter");
			baseArr.push("foreach");
			baseArr.push("exists");
			baseArr.push("has");
			baseArr.push("mapi");
			baseArr.push("map");
			baseArr.push("list");
			baseArr.push("array");
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
			return ((haxe.lang.Class) (( (( Lambda.__hx_class != default(haxe.lang.Class) )) ? (Lambda.__hx_class) : (Lambda.__hx_class = new haxe.lang.Class(new Lambda(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Lambda(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Lambda();
		}
	}
	
	
}


