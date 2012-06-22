
public class EntryPoint__Main
{
	public static void Main()
	{
		global::Main.main();
	}
}
public  class Main 
{
	public static   void main()
	{
		unchecked 
		{
			haxe.Log.trace.__hx_invoke2_o(default(double), default(double), "\x0A\x0A", new haxe.lang.DynamicObject(new Array<int>(new int[]{302979532, 1547539107, 1648581351}), new Array<object>(new object[]{"main", "Main", "Main.hx"}), new Array<int>(new int[]{1981972957}), new Array<double>(new double[]{5})));
			Array<object> x = new Array<object>(new object[]{new Array<object>(new object[]{0, 1, 2, 6}), new Array<object>(new object[]{2}), new Array<object>(new object[]{4, 5})});
			haxe.lang.Function walk = default(haxe.lang.Function);
			{
				Array<object> walk1 = new Array<object>(new object[]{default(haxe.lang.Function)});
				walk1[0] = new Fun_29d57daf(walk1);
				walk = ((haxe.lang.Function) (walk1[0]) );
			}
			
			walk.__hx_invoke1_o(default(double), x.iterator());
			haxe.Log.trace.__hx_invoke2_o(default(double), default(double), "\x0A\x0A\x0A\x0A", new haxe.lang.DynamicObject(new Array<int>(new int[]{302979532, 1547539107, 1648581351}), new Array<object>(new object[]{"main", "Main", "Main.hx"}), new Array<int>(new int[]{1981972957}), new Array<double>(new double[]{14})));
		}
	}
	
	
}



public  class Fun_29d57daf : haxe.lang.Function 
{
	public    Fun_29d57daf(Array<object> walk1) : base(1, 0)
	{
		unchecked 
		{
			this.walk1 = walk1;
		}
	}
	
	
	public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
	{
		unchecked 
		{
			object list = ( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
			object __temp_stmt52 = default(object);
			{
				object __ret = ((object) (default(object)) );
				bool matched = false;
				{
					if ( ! (matched) ) 
					{
						string b = (( default(object) + "" ));
						string a = (( default(object) + "" ));
						object l = ((object) (default(object)) );
						object r = ((object) (default(object)) );
						{
							l = Reflect.copy<object>(list);
							if (((bool) (haxe.lang.Runtime.callField(l, "hasNext", 407283053, default(Array))) )) 
							{
								object __pm1997 = ((object) (haxe.lang.Runtime.callField(l, "next", 1224901875, default(Array))) );
								{
									object __temp_expr53 = __pm1997;
									{
										r = ((object) (haxe.lang.Runtime.callField(__pm1997, "iterator", 328878574, default(Array))) );
										if (((bool) (haxe.lang.Runtime.callField(r, "hasNext", 407283053, default(Array))) )) 
										{
											string __pm1617 = (( haxe.lang.Runtime.callField(r, "next", 1224901875, default(Array)) + "" ));
											if (((bool) (haxe.lang.Runtime.callField(r, "hasNext", 407283053, default(Array))) )) 
											{
												string __pm2617 = (( haxe.lang.Runtime.callField(r, "next", 1224901875, default(Array)) + "" ));
												{
													a = __pm1617;
													{
														b = __pm2617;
														matched = true;
													}
													
												}
												
											}
											
										}
										
									}
									
								}
								
							}
							
						}
						
						if (matched) 
						{
							object __temp_stmt54 = default(object);
							{
								haxe.Log.trace.__hx_invoke2_o(default(double), default(double), (( ( ( ( ( "(" + a ) + "," ) + b ) + ")" ) + "" )), new haxe.lang.DynamicObject(new Array<int>(new int[]{302979532, 1547539107, 1648581351}), new Array<object>(new object[]{"main", "Main", "Main.hx"}), new Array<int>(new int[]{1981972957}), new Array<double>(new double[]{8})));
								__temp_stmt54 = ((object) (((haxe.lang.Function) (this.walk1[0]) ).__hx_invoke1_o(default(double), l)) );
							}
							
							__ret = ((object) (__temp_stmt54) );
						}
						
					}
					
					if ( ! (matched) ) 
					{
						object l1 = ((object) (default(object)) );
						{
							l1 = Reflect.copy<object>(list);
							if (((bool) (haxe.lang.Runtime.callField(l1, "hasNext", 407283053, default(Array))) )) 
							{
								object __pm98 = ((object) (haxe.lang.Runtime.callField(l1, "next", 1224901875, default(Array))) );
								matched = true;
							}
							
						}
						
						if (matched) 
						{
							__ret = ((object) (((haxe.lang.Function) (this.walk1[0]) ).__hx_invoke1_o(default(double), l1)) );
						}
						
					}
					
					if ( ! (matched) ) 
					{
						if (( ((bool) (haxe.lang.Runtime.callField(Reflect.copy<object>(list), "hasNext", 407283053, default(Array))) ) == false )) 
						{
							matched = true;
						}
						
						if (matched) 
						{
							__ret = ((object) (haxe.Log.trace.__hx_invoke2_o(default(double), default(double), "Done", new haxe.lang.DynamicObject(new Array<int>(new int[]{302979532, 1547539107, 1648581351}), new Array<object>(new object[]{"main", "Main", "Main.hx"}), new Array<int>(new int[]{1981972957}), new Array<double>(new double[]{10})))) );
						}
						
					}
					
				}
				
				__temp_stmt52 = __ret;
			}
			
			return __temp_stmt52;
		}
	}
	
	
	public  Array<object> walk1;
	
}



public  class Color : haxe.lang.Enum 
{
	static Color() 
	{
		Color.constructs = new Array<object>(new object[]{"Red", "SubColor", "Orange"});
		Color.Orange = new Color(2, default(Array<object>));
	}
	public    Color(int index, Array<object> @params) : base(index, @params)
	{
		unchecked 
		{
			Color.__hx_ctor(this, index, @params);
		}
	}
	
	
	public static   void __hx_ctor(Color __temp_me8, int index, Array<object> @params)
	{
		unchecked 
		{
			object __temp_expr55 = default(object);
		}
	}
	
	
	public static  Array<object> constructs;
	
	public static   Color Red(Array<int> val)
	{
		unchecked 
		{
			return new Color(0, new Array<object>(new object[]{val}));
		}
	}
	
	
	public static   Color SubColor(Color c, int x)
	{
		unchecked 
		{
			return new Color(1, new Array<object>(new object[]{c, x}));
		}
	}
	
	
	public static  Color Orange;
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( Color.__hx_class != default(haxe.lang.Class) )) ? (Color.__hx_class) : (Color.__hx_class = new haxe.lang.Class(new Color(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    Color(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
	{
		unchecked 
		{
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
					case 2052138766:
					{
						return Color.Orange = ((Color) (@value) );
					}
					
					
					case 1744813180:
					{
						return Color.constructs = ((Array<object>) (((Array) (@value) ).cast<object>()) );
					}
					
					
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
					case 2052138766:
					{
						return Color.Orange;
					}
					
					
					case 422413283:
					{
						return new haxe.lang.Closure("SubColor", 422413283, ((haxe.lang.IHxObject) (Color.__hx_getClassStatic()) ));
					}
					
					
					case 4100401:
					{
						return new haxe.lang.Closure("Red", 4100401, ((haxe.lang.IHxObject) (Color.__hx_getClassStatic()) ));
					}
					
					
					case 1744813180:
					{
						return Color.constructs;
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
					case 422413283:
					{
						return Color.SubColor(((Color) (dynargs[0]) ), haxe.lang.Runtime.toInt(dynargs[1]));
					}
					
					
					case 4100401:
					{
						return Color.Red(((Array<int>) (((Array) (dynargs[0]) ).cast<int>()) ));
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
			baseArr.push("Orange");
			baseArr.push("SubColor");
			baseArr.push("Red");
			baseArr.push("constructs");
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
			return ((haxe.lang.Class) (( (( Color.__hx_class != default(haxe.lang.Class) )) ? (Color.__hx_class) : (Color.__hx_class = new haxe.lang.Class(new Color(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Color(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Color(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
		}
	}
	
	
}


