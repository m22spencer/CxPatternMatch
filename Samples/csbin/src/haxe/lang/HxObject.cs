
namespace haxe.lang
{
	public  interface IHxObject 
	{
		   double __hx_setField_f(string field, int hash, bool isStatic, double @value);
		
		   object __hx_setField(string field, int hash, bool isStatic, object @value);
		
		   object __hx_getField(string field, int hash, bool isStatic, bool throwErrors, bool isCheck);
		
		   double __hx_getField_f(string field, int hash, bool isStatic, bool throwErrors);
		
		   object __hx_invokeField(string field, int hash, bool isStatic, Array dynargs);
		
		   bool __hx_deleteField(string field, int hash);
		
		   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck);
		
		   double __hx_lookupField_f(string field, int hash, bool throwErrors);
		
		   object __hx_lookupSetField(string field, int hash, object @value);
		
		   double __hx_lookupSetField_f(string field, int hash, double @value);
		
		   void __hx_classFields(Array<object> baseArr);
		
		   void __hx_getFields(Array<object> baseArr, bool isInstanceFields);
		
		   haxe.lang.Class __hx_getClass();
		
		   object __hx_createEmpty();
		
		   object __hx_create(Array arr);
		
	}
}



namespace haxe.lang
{
	public  class HxObject : haxe.lang.IHxObject 
	{
		public    HxObject() : base()
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
				return ((haxe.lang.Class) (( (( haxe.lang.HxObject.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.HxObject.__hx_class) : (haxe.lang.HxObject.__hx_class = new haxe.lang.Class(new haxe.lang.HxObject(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    HxObject(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, bool isStatic, double @value)
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
						default:
						{
							return this.__hx_lookupSetField_f(field, hash, @value);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   object __hx_setField(string field, int hash, bool isStatic, object @value)
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
						default:
						{
							return this.__hx_lookupSetField(field, hash, @value);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   object __hx_getField(string field, int hash, bool isStatic, bool throwErrors, bool isCheck)
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
						default:
						{
							return this.__hx_lookupField(field, hash, throwErrors, isCheck);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   double __hx_getField_f(string field, int hash, bool isStatic, bool throwErrors)
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
						default:
						{
							return this.__hx_lookupField_f(field, hash, throwErrors);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   object __hx_invokeField(string field, int hash, bool isStatic, Array dynargs)
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
						default:
						{
							return ((haxe.lang.Function) (this.__hx_getField(field, hash, false, true, false)) ).__hx_invokeDynamic(dynargs);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				return false;
			}
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				if (isCheck) 
				{
					return haxe.lang.Runtime.undefined;
				}
				 else 
				{
					if (throwErrors) 
					{
						throw haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						return default(object);
					}
					
				}
				
			}
		}
		
		
		public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors)
		{
			unchecked 
			{
				if (throwErrors) 
				{
					throw haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					return default(double);
				}
				
			}
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				throw haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				throw haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
		}
		
		
		public virtual   void __hx_classFields(Array<object> baseArr)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void __hx_getFields(Array<object> baseArr, bool isInstanceFields)
		{
			unchecked 
			{
				if (isInstanceFields) 
				{
					{
					}
					
				}
				
			}
		}
		
		
		public virtual   haxe.lang.Class __hx_getClass()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.lang.HxObject.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.HxObject.__hx_class) : (haxe.lang.HxObject.__hx_class = new haxe.lang.Class(new haxe.lang.HxObject(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public virtual   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.HxObject(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public virtual   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.HxObject();
			}
		}
		
		
	}
}



namespace haxe.lang
{
	public  class DynamicObject : haxe.lang.HxObject 
	{
		public    DynamicObject() : base()
		{
			unchecked 
			{
				haxe.lang.DynamicObject.__hx_ctor(this);
			}
		}
		
		
		public static   void __hx_ctor(haxe.lang.DynamicObject __temp_me11)
		{
			unchecked 
			{
				object __temp_expr57 = default(object);
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.lang.DynamicObject.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.DynamicObject.__hx_class) : (haxe.lang.DynamicObject.__hx_class = new haxe.lang.Class(new haxe.lang.DynamicObject(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    DynamicObject(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    DynamicObject(Array<int> __hx_hashes, Array<object> __hx_dynamics, Array<int> __hx_hashes_f, Array<double> __hx_dynamics_f)
		{
			unchecked 
			{
				this.__hx_hashes = __hx_hashes;
				this.__hx_dynamics = __hx_dynamics;
				this.__hx_hashes_f = __hx_hashes_f;
				this.__hx_dynamics_f = __hx_dynamics_f;
			}
		}
		
		
		public override   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
				if (( res >= 0 )) 
				{
					this.__hx_hashes.splice(res, 1);
					this.__hx_dynamics.splice(res, 1);
					return true;
				}
				 else 
				{
					res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
					if (( res >= 0 )) 
					{
						this.__hx_hashes_f.splice(res, 1);
						this.__hx_dynamics_f.splice(res, 1);
						return true;
					}
					
				}
				
				return false;
			}
		}
		
		
		public  Array<int> __hx_hashes = new Array<int>(new int[]{});
		
		public  Array<object> __hx_dynamics = new Array<object>(new object[]{});
		
		public  Array<int> __hx_hashes_f = new Array<int>(new int[]{});
		
		public  Array<double> __hx_dynamics_f = new Array<double>(new double[]{});
		
		public override   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
				if (( res >= 0 )) 
				{
					return this.__hx_dynamics[res];
				}
				 else 
				{
					res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
					if (( res >= 0 )) 
					{
						return this.__hx_dynamics_f[res];
					}
					
				}
				
				if (isCheck) 
				{
					return haxe.lang.Runtime.undefined;
				}
				 else 
				{
					return default(object);
				}
				
			}
		}
		
		
		public override   double __hx_lookupField_f(string field, int hash, bool throwErrors)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
				if (( res >= 0 )) 
				{
					return this.__hx_dynamics_f[res];
				}
				 else 
				{
					res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
					if (( res >= 0 )) 
					{
						return haxe.lang.Runtime.toDouble(this.__hx_dynamics[res]);
					}
					
				}
				
				return default(double);
			}
		}
		
		
		public override   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
				if (( res >= 0 )) 
				{
					return this.__hx_dynamics[res] = ((object) (@value) );
				}
				 else 
				{
					int res2 = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
					if (( res >= 0 )) 
					{
						this.__hx_hashes_f.splice(res2, 1);
						this.__hx_dynamics_f.splice(res2, 1);
					}
					
				}
				
				this.__hx_hashes.insert( ~ (res) , hash);
				this.__hx_dynamics.insert( ~ (res) , ((object) (@value) ));
				return @value;
			}
		}
		
		
		public override   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
				if (( res >= 0 )) 
				{
					return this.__hx_dynamics_f[res] = @value;
				}
				 else 
				{
					int res2 = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
					if (( res >= 0 )) 
					{
						this.__hx_hashes.splice(res2, 1);
						this.__hx_dynamics.splice(res2, 1);
					}
					
				}
				
				this.__hx_hashes_f.insert( ~ (res) , hash);
				this.__hx_dynamics_f.insert( ~ (res) , @value);
				return @value;
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
					{
						object __temp_iterator48 = this.__hx_hashes.iterator();
						while (((bool) (haxe.lang.Runtime.callField(__temp_iterator48, "hasNext", 407283053, default(Array))) ))
						{
							int __temp_field13 = haxe.lang.Runtime.toInt(haxe.lang.Runtime.callField(__temp_iterator48, "next", 1224901875, default(Array)));
							baseArr.push(haxe.lang.FieldLookup.lookupHash(__temp_field13));
						}
						
					}
					
					{
						object __temp_iterator49 = this.__hx_hashes_f.iterator();
						while (((bool) (haxe.lang.Runtime.callField(__temp_iterator49, "hasNext", 407283053, default(Array))) ))
						{
							int __temp_field12 = haxe.lang.Runtime.toInt(haxe.lang.Runtime.callField(__temp_iterator49, "next", 1224901875, default(Array)));
							baseArr.push(haxe.lang.FieldLookup.lookupHash(__temp_field12));
						}
						
					}
					
					base.__hx_getFields(baseArr, isInstanceFields);
				}
				
			}
		}
		
		
		public override   haxe.lang.Class __hx_getClass()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.lang.DynamicObject.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.DynamicObject.__hx_class) : (haxe.lang.DynamicObject.__hx_class = new haxe.lang.Class(new haxe.lang.DynamicObject(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.DynamicObject(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.DynamicObject();
			}
		}
		
		
	}
}



namespace haxe.lang
{
	public  class Class : haxe.lang.HxObject 
	{
		public    Class(haxe.lang.IHxObject cls) : base(haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				haxe.lang.Class.__hx_ctor(this, cls);
			}
		}
		
		
		public static   void __hx_ctor(haxe.lang.Class __temp_me14, haxe.lang.IHxObject cls)
		{
			unchecked 
			{
				__temp_me14.classProxy = cls;
			}
		}
		
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (default(object)) );
			}
		}
		
		
		public    Class(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return this.classProxy.__hx_createEmpty();
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return this.classProxy.__hx_create(arr);
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, bool isStatic, Array dynArgs)
		{
			unchecked 
			{
				return this.classProxy.__hx_invokeField(field, hash, true, dynArgs);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, bool isStatic, object @value)
		{
			unchecked 
			{
				return this.classProxy.__hx_setField(field, hash, true, @value);
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool isStatic, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				return this.classProxy.__hx_getField(field, hash, true, throwErrors, isCheck);
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, bool isStatic, double @value)
		{
			unchecked 
			{
				return this.classProxy.__hx_setField_f(field, hash, true, @value);
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool isStatic, bool throwErrors)
		{
			unchecked 
			{
				return this.classProxy.__hx_getField_f(field, hash, true, throwErrors);
			}
		}
		
		
		public override   void __hx_classFields(Array<object> baseArr)
		{
			unchecked 
			{
				this.classProxy.__hx_classFields(baseArr);
			}
		}
		
		
		public override   void __hx_getFields(Array<object> baseArr, bool isInstanceFields)
		{
			unchecked 
			{
				if (isInstanceFields) 
				{
					this.classProxy.__hx_getFields(baseArr, isInstanceFields);
				}
				 else 
				{
					this.__hx_classFields(baseArr);
				}
				
			}
		}
		
		
		public  haxe.lang.IHxObject classProxy;
		
		public virtual   System.Type nativeType()
		{
						return classProxy.GetType();	
		}
		
		
		public override   haxe.lang.Class __hx_getClass()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (default(object)) );
			}
		}
		
		
	}
}



namespace haxe.lang
{
	public  class NativeClassWrapper : haxe.lang.Class 
	{
		public    NativeClassWrapper(System.Type native) : base(haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				haxe.lang.NativeClassWrapper.__hx_ctor(this, native);
			}
		}
		
		
		public static   void __hx_ctor(haxe.lang.NativeClassWrapper __temp_me15, System.Type native)
		{
			unchecked 
			{
				haxe.lang.Class.__hx_ctor(__temp_me15, default(haxe.lang.IHxObject));
				__temp_me15.native = native;
			}
		}
		
		
		public static   object getClassStatic()
		{
			unchecked 
			{
				return default(object);
			}
		}
		
		
		public static   object __hx_getClassStatic()
		{
			unchecked 
			{
				return haxe.lang.NativeClassWrapper.getClassStatic();
			}
		}
		
		
		public    NativeClassWrapper(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public  System.Type native;
		
		public override   System.Type nativeType()
		{
			unchecked 
			{
				return this.native;
			}
		}
		
		
		public virtual   object getField(string field, int hash, bool isStatic, bool throwErrors, bool isCheck)
		{
				System.Reflection.MemberInfo[] mis = native.GetMember(field, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);		System.Reflection.MemberInfo mi = null;		if (mis.Length > 0)		{			mi = mis[0];			if (mi is System.Reflection.FieldInfo)			{				return ((System.Reflection.FieldInfo) mi).GetValue(null);			} else if (mi is System.Reflection.PropertyInfo)			{				return ((System.Reflection.PropertyInfo) mi).GetValue(null, null);			} else {				return new haxe.lang.Closure(field, hash, this);			}		} else {			if (isCheck)			{				return haxe.lang.Runtime.undefined;			} else if (throwErrors) {				throw haxe.lang.HaxeException.wrap("Cannot find field '" + field + "' on Class '" + native );			} else {				return null;			}		}	
		}
		
		
		public virtual   double getField_f(string field, int hash, bool isStatic, bool throwErrors)
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.getField(field, hash, isStatic, throwErrors, false));
			}
		}
		
		
		public virtual   object setField(string field, int hash, bool isStatic, object val)
		{
					System.Reflection.MemberInfo[] mis = native.GetMember(field, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);		System.Reflection.MemberInfo mi = null;		if (mis.Length > 0)		{			mi = mis[0];			if (mi is System.Reflection.FieldInfo)			{				((System.Reflection.FieldInfo) mi).SetValue(null, val);				return val;			} else if (mi is System.Reflection.PropertyInfo)			{				((System.Reflection.PropertyInfo) mi).SetValue(null, val, null);				return val;			}		}				throw haxe.lang.HaxeException.wrap("Field '" + field + "' doesn't exist or is not accessible for writing on Class " + native );	
		}
		
		
		public virtual   double setField_f(string field, int hash, bool isStatic, double val)
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.setField(field, hash, isStatic, val));
			}
		}
		
		
		public virtual   object invokeField(string field, int hash, bool isStatic, Array dynArgs)
		{
						object[] nargs = (dynArgs == null) ? new object[0] : cs.Lib.toNativeReadOnlyArray<object>(((Array<object>)dynArgs.cast<object>()), true);						System.Type[] types = new System.Type[nargs.Length];            for (int i = 0; i < nargs.Length; i++)                types[i] = nargs[i].GetType();							System.Reflection.MethodInfo mi = native.GetMethod(field, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic, null, types, new System.Reflection.ParameterModifier[0]);			if (mi == null)			{				throw haxe.lang.HaxeException.wrap("Method '" + field + "' not found from type " + native + " or incompatible type arguments");			}						return mi.Invoke(null, nargs);	
		}
		
		
		public virtual   void classFields(Array<object> baseArr)
		{
						System.Reflection.MemberInfo[] members = native.GetMembers(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);			string last = null;			for (int i = 0; i < members.Length; i++)            {				if (members[i].Name != last)					baseArr.push(last = members[i].Name);            }	
		}
		
		
		public virtual   void getFields(Array<object> baseArr, bool isInstanceFields)
		{
						if (isInstanceFields)			{				System.Reflection.MemberInfo[] members = native.GetMembers(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);								string last = null;				for (int i = 0; i < members.Length; i++)				{					if (members[i].Name != last)						baseArr.push(last = members[i].Name);				}			} else {				this.classFields(baseArr);			}	
		}
		
		
		public virtual   object create(Array args)
		{
						object[] nargs = (args == null) ? new object[0] : cs.Lib.toNativeReadOnlyArray<object>(((Array<object>)args.cast<object>()), true);						System.Type[] types = new System.Type[nargs.Length];            for (int i = 0; i < nargs.Length; i++)                types[i] = nargs[i].GetType();						System.Reflection.ConstructorInfo c = native.GetConstructor(types);            return c.Invoke(nargs);	
		}
		
		
		public virtual   object createEmpty()
		{
						System.Type[] empty = new System.Type[0];			System.Reflection.ConstructorInfo c = native.GetConstructor(empty);			if (c == null)				throw new haxe.lang.HaxeException("Cannot apply createEmpty for native type " + native);			return c.Invoke(new object[0]);	
		}
		
		
		public virtual   haxe.lang.Class getClass()
		{
			unchecked 
			{
				return default(haxe.lang.Class);
			}
		}
		
		
		public override   haxe.lang.Class __hx_getClass()
		{
			unchecked 
			{
				return this.getClass();
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return this.createEmpty();
			}
		}
		
		
		public override   object __hx_create(Array args)
		{
			unchecked 
			{
				return this.create(args);
			}
		}
		
		
		public override   void __hx_getFields(Array<object> baseArr, bool isInstanceFields)
		{
			unchecked 
			{
				this.getFields(baseArr, isInstanceFields);
			}
		}
		
		
		public override   void __hx_classFields(Array<object> baseArr)
		{
			unchecked 
			{
				this.classFields(baseArr);
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, bool isStatic, Array dynArgs)
		{
			unchecked 
			{
				return this.invokeField(field, hash, isStatic, dynArgs);
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, bool isStatic, double val)
		{
			unchecked 
			{
				return this.setField_f(field, hash, isStatic, val);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, bool isStatic, object val)
		{
			unchecked 
			{
				return this.setField(field, hash, isStatic, val);
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool isStatic, bool throwErrors)
		{
			unchecked 
			{
				return this.getField_f(field, hash, isStatic, throwErrors);
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool isStatic, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				return this.getField(field, hash, isStatic, throwErrors, isCheck);
			}
		}
		
		
	}
}



namespace haxe.lang
{
	public  class Enum : haxe.lang.HxObject 
	{
		public    Enum(int index, Array<object> @params)
		{
			unchecked 
			{
				this.index = index;
				this.@params = @params;
			}
		}
		
		
		public static  haxe.lang.Class __hx_class;
		
		public static   haxe.lang.Class __hx_getClassStatic()
		{
			unchecked 
			{
				return ((haxe.lang.Class) (( (( haxe.lang.Enum.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.Enum.__hx_class) : (haxe.lang.Enum.__hx_class = new haxe.lang.Class(new haxe.lang.Enum(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public    Enum(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
		public readonly int index;
		
		public readonly Array<object> @params;
		
		public virtual   string getTag()
		{
			unchecked 
			{
				object cl = ((haxe.lang.Class) (Type.getClass<object>(this)) );
				return (( haxe.lang.Runtime.callField(haxe.lang.Runtime.getField(cl, "constructs", 1744813180, true), "__get", 1915412854, new Array<object>(new object[]{this.index})) + "" ));
			}
		}
		
		
		public virtual   bool @equals(object obj)
		{
			unchecked 
			{
				if (haxe.lang.Runtime.eq(obj, this)) 
				{
					return true;
				}
				
				haxe.lang.Enum obj1 = ((haxe.lang.Enum) (obj) );
				bool ret = ( ( ( obj1 != default(haxe.lang.Enum) ) && Std.@is(obj1, ((haxe.lang.Class) (Type.getClass<object>(this)) )) ) && ( obj1.index == this.index ) );
				if ( ! (ret) ) 
				{
					return false;
				}
				
				if (( obj1.@params == this.@params )) 
				{
					return true;
				}
				
				int len = 0;
				if (( ( ( obj1.@params == default(Array<object>) ) || ( this.@params == default(Array<object>) ) ) || ( (len = this.@params.length) != obj1.@params.length ) )) 
				{
					return false;
				}
				
				{
					int _g = 0;
					while (( _g < len ))
					{
						int i = _g++;
						if (( ! (haxe.lang.Runtime.refEq(obj1.@params[i], this.@params[i])) )) 
						{
							return false;
						}
						
					}
					
				}
				
				return true;
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
						case 1072885311:
						{
							return new haxe.lang.Closure("equals", 1072885311, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 589796196:
						{
							return new haxe.lang.Closure("getTag", 589796196, ((haxe.lang.IHxObject) (this) ));
						}
						
						
						case 1836776262:
						{
							return this.@params;
						}
						
						
						case 1041537810:
						{
							return this.index;
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
						case 1041537810:
						{
							return this.index;
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
						case 1072885311:
						{
							return this.@equals(dynargs[0]);
						}
						
						
						case 589796196:
						{
							return this.getTag();
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
				baseArr.push("params");
				baseArr.push("index");
				if (isInstanceFields) 
				{
					baseArr.push("equals");
					baseArr.push("getTag");
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
				return ((haxe.lang.Class) (( (( haxe.lang.Enum.__hx_class != default(haxe.lang.Class) )) ? (haxe.lang.Enum.__hx_class) : (haxe.lang.Enum.__hx_class = new haxe.lang.Class(new haxe.lang.Enum(haxe.lang.EmptyObject.EMPTY))) )) );
			}
		}
		
		
		public override   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.Enum(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public override   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.Enum(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
	}
}


