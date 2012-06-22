
public  class Hash<T> : haxe.lang.HxObject, Hash 
{
	public    Hash() : base()
	{
		unchecked 
		{
			Hash<object>.__hx_ctor<T>(this);
		}
	}
	
	
	public static   void __hx_ctor<T2>(Hash<T2> __temp_me5)
	{
		unchecked 
		{
			__temp_me5.keysArr = new Array<object>(new object[]{});
			__temp_me5.valuesArr = new Array<T2>(new T2[]{});
		}
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( Hash<object>.__hx_class != default(haxe.lang.Class) )) ? (Hash<object>.__hx_class) : (Hash<object>.__hx_class = new haxe.lang.Class(new Hash<object>(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    Hash(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	   object Hash.cast<T1>()
	{
		unchecked 
		{
			if (( typeof(T) == typeof(T1) )) 
			{
				return this;
			}
			
			Hash<T1> new_me = new Hash<T1>(haxe.lang.EmptyObject.EMPTY);
			{
				object __temp_iterator29 = Reflect.fields(this).iterator();
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator29, "hasNext", 407283053, default(Array))) ))
				{
					string field = (( haxe.lang.Runtime.callField(__temp_iterator29, "next", 1224901875, default(Array)) + "" ));
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
	
	
	public  Array<object> keysArr;
	
	public  Array<T> valuesArr;
	
	public virtual   void @set(string key, T @value)
	{
		unchecked 
		{
			this.keysArr.push(key);
			this.valuesArr.push(@value);
		}
	}
	
	
	public virtual   haxe.lang.Null<T> @get(string key)
	{
		unchecked 
		{
			int i = 0;
			{
				int _g = 0;
				Array<object> _g1 = this.keysArr;
				while (( _g < _g1.length ))
				{
					string k = (( _g1[_g] + "" ));
					 ++ _g;
					if (haxe.lang.Runtime.eq(k, key)) 
					{
						return new haxe.lang.Null<T>(this.valuesArr[i], true);
					}
					
					i++;
				}
				
			}
			
			return default(haxe.lang.Null<T>);
		}
	}
	
	
	public virtual   bool exists(string key)
	{
		unchecked 
		{
			{
				int _g = 0;
				Array<object> _g1 = this.keysArr;
				while (( _g < _g1.length ))
				{
					string k = (( _g1[_g] + "" ));
					 ++ _g;
					if (haxe.lang.Runtime.eq(k, key)) 
					{
						return true;
					}
					
				}
				
			}
			
			return false;
		}
	}
	
	
	public virtual   bool @remove(string key)
	{
		unchecked 
		{
			int i = 0;
			{
				int _g = 0;
				Array<object> _g1 = this.keysArr;
				while (( _g < _g1.length ))
				{
					string k = (( _g1[_g] + "" ));
					 ++ _g;
					if (haxe.lang.Runtime.eq(k, key)) 
					{
						this.keysArr.splice(i, 1);
						this.valuesArr.splice(i, 1);
						return true;
					}
					
					i++;
				}
				
			}
			
			return false;
		}
	}
	
	
	public virtual   object keys()
	{
		unchecked 
		{
			return this.keysArr.iterator();
		}
	}
	
	
	public virtual   object iterator()
	{
		unchecked 
		{
			return this.valuesArr.iterator();
		}
	}
	
	
	public virtual   string toString()
	{
		unchecked 
		{
			StringBuf s = new StringBuf();
			s.b.Append("{");
			object it = this.keys();
			{
				object __temp_iterator30 = it;
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator30, "hasNext", 407283053, default(Array))) ))
				{
					string i = (( haxe.lang.Runtime.callField(__temp_iterator30, "next", 1224901875, default(Array)) + "" ));
					s.b.Append(i);
					s.b.Append(" => ");
					s.b.Append((( this.@get(i).@value + "" )));
					if (((bool) (haxe.lang.Runtime.callField(it, "hasNext", 407283053, default(Array))) )) 
					{
						s.b.Append(", ");
					}
					
				}
				
			}
			
			s.b.Append("}");
			return s.b.ToString();
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
					case 769706911:
					{
						return this.valuesArr = ((Array<T>) (((Array) (@value) ).cast<T>()) );
					}
					
					
					case 993363149:
					{
						return this.keysArr = ((Array<object>) (((Array) (@value) ).cast<object>()) );
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
					case 946786476:
					{
						return new haxe.lang.Closure("toString", 946786476, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 328878574:
					{
						return new haxe.lang.Closure("iterator", 328878574, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1191633396:
					{
						return new haxe.lang.Closure("keys", 1191633396, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 76061764:
					{
						return new haxe.lang.Closure("remove", 76061764, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 1071652316:
					{
						return new haxe.lang.Closure("exists", 1071652316, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 5144726:
					{
						return new haxe.lang.Closure("get", 5144726, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 5741474:
					{
						return new haxe.lang.Closure("set", 5741474, ((haxe.lang.IHxObject) (this) ));
					}
					
					
					case 769706911:
					{
						return this.valuesArr;
					}
					
					
					case 993363149:
					{
						return this.keysArr;
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
					
					
					case 328878574:
					{
						return this.iterator();
					}
					
					
					case 1191633396:
					{
						return this.keys();
					}
					
					
					case 76061764:
					{
						return this.@remove((( dynargs[0] + "" )));
					}
					
					
					case 1071652316:
					{
						return this.exists((( dynargs[0] + "" )));
					}
					
					
					case 5144726:
					{
						return (this.@get((( dynargs[0] + "" )))).toDynamic();
					}
					
					
					case 5741474:
					{
						this.@set((( dynargs[0] + "" )), ((T) (dynargs[1]) ));
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
			baseArr.push("valuesArr");
			baseArr.push("keysArr");
			if (isInstanceFields) 
			{
				baseArr.push("toString");
				baseArr.push("iterator");
				baseArr.push("keys");
				baseArr.push("remove");
				baseArr.push("exists");
				baseArr.push("get");
				baseArr.push("set");
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
			return ((haxe.lang.Class) (( (( Hash<object>.__hx_class != default(haxe.lang.Class) )) ? (Hash<object>.__hx_class) : (Hash<object>.__hx_class = new haxe.lang.Class(new Hash<object>(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Hash<object>(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Hash<object>();
		}
	}
	
	
	public override string ToString()
	{
		return this.toString();
	}
	
	
}



public  interface Hash : haxe.lang.IHxObject 
{
	   object cast<T1>();
	
}


