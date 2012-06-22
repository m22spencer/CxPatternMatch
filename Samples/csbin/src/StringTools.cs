
public  class StringTools : haxe.lang.HxObject 
{
	public    StringTools() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   string urlEncode(string s)
	{
		unchecked 
		{
			return System.Uri.EscapeUriString(s);
		}
	}
	
	
	public static   string urlDecode(string s)
	{
		unchecked 
		{
			return System.Uri.UnescapeDataString(s);
		}
	}
	
	
	public static   string htmlEscape(string s)
	{
		unchecked 
		{
			return haxe.lang.StringExt.split(haxe.lang.StringExt.split(haxe.lang.StringExt.split(s, "&").@join("&amp;"), "<").@join("&lt;"), ">").@join("&gt;");
		}
	}
	
	
	public static   string htmlUnescape(string s)
	{
		unchecked 
		{
			return haxe.lang.StringExt.split(haxe.lang.StringExt.split(haxe.lang.StringExt.split(s, "&gt;").@join(">"), "&lt;").@join("<"), "&amp;").@join("&");
		}
	}
	
	
	public static   bool startsWith(string s, string start)
	{
		unchecked 
		{
			return s.StartsWith(start);
		}
	}
	
	
	public static   object endsWith(string s, string end)
	{
		unchecked 
		{
			return s.EndsWith(end);
		}
	}
	
	
	public static   bool isSpace(string s, int pos)
	{
		unchecked 
		{
			haxe.lang.Null<int> c = haxe.lang.StringExt.charCodeAt(s, pos);
			return ( ( ( c.@value >= 9 ) && ( c.@value <= 13 ) ) || haxe.lang.Runtime.eq((c).toDynamic(), 32) );
		}
	}
	
	
	public static   string ltrim(string s)
	{
		unchecked 
		{
			return s.TrimStart();
		}
	}
	
	
	public static   string rtrim(string s)
	{
		unchecked 
		{
			return s.TrimEnd();
		}
	}
	
	
	public static   string trim(string s)
	{
		unchecked 
		{
			return (( haxe.lang.Runtime.callField(s, "Trim", 937216258, default(Array)) + "" ));
		}
	}
	
	
	public static   string rpad(string s, string c, int l)
	{
		unchecked 
		{
			int sl = s.Length;
			int cl = c.Length;
			while (( sl < l ))
			{
				if (( ( l - sl ) < cl )) 
				{
					s += haxe.lang.StringExt.substr(c, 0, new haxe.lang.Null<int>(( l - sl ), true));
					sl = l;
				}
				 else 
				{
					s += c;
					sl += cl;
				}
				
			}
			
			return s;
		}
	}
	
	
	public static   string lpad(string s, string c, int l)
	{
		unchecked 
		{
			string ns = "";
			int sl = s.Length;
			if (( sl >= l )) 
			{
				return s;
			}
			
			int cl = c.Length;
			while (( sl < l ))
			{
				if (( ( l - sl ) < cl )) 
				{
					ns += haxe.lang.StringExt.substr(c, 0, new haxe.lang.Null<int>(( l - sl ), true));
					sl = l;
				}
				 else 
				{
					ns += c;
					sl += cl;
				}
				
			}
			
			return ( ns + s );
		}
	}
	
	
	public static   string replace(string s, string sub, string @by)
	{
		unchecked 
		{
			return s.Replace(sub, @by);
		}
	}
	
	
	public static   string hex(int n, haxe.lang.Null<int> digits)
	{
		unchecked 
		{
			string s = "";
			string hexChars = "0123456789ABCDEF";
			do 
			{
				s = ( haxe.lang.StringExt.charAt(hexChars, ( n & 15 )) + s );
				n = ((int) (( ((uint) (n) ) >> 4 )) );
			}
			while (( n > 0 ));
			if (( ! (( digits.@value == default(haxe.lang.Null<int>).@value )) )) 
			{
				while (( s.Length < digits.@value ))
				{
					s = ( "0" + s );
				}
				
			}
			
			return s;
		}
	}
	
	
	public static   int fastCodeAt(string s, int index)
	{
		unchecked 
		{
			if (( ((uint) (index) ) >= s.Length )) 
			{
				return 0;
			}
			 else 
			{
				return haxe.lang.Runtime.toInt(s[index]);
			}
			
		}
	}
	
	
	public static   bool isEOF(int c)
	{
		unchecked 
		{
			return ( c == 0 );
		}
	}
	
	
	public static  haxe.lang.Class __hx_class;
	
	public static   haxe.lang.Class __hx_getClassStatic()
	{
		unchecked 
		{
			return ((haxe.lang.Class) (( (( StringTools.__hx_class != default(haxe.lang.Class) )) ? (StringTools.__hx_class) : (StringTools.__hx_class = new haxe.lang.Class(new StringTools(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public    StringTools(haxe.lang.EmptyObject empty) : base()
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
					case 1095439090:
					{
						return new haxe.lang.Closure("isEOF", 1095439090, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 173105980:
					{
						return new haxe.lang.Closure("fastCodeAt", 173105980, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 5194459:
					{
						return new haxe.lang.Closure("hex", 5194459, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 724060212:
					{
						return new haxe.lang.Closure("replace", 724060212, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 1203264615:
					{
						return new haxe.lang.Closure("lpad", 1203264615, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 1269802017:
					{
						return new haxe.lang.Closure("rpad", 1269802017, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 1292082402:
					{
						return new haxe.lang.Closure("trim", 1292082402, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 1890696788:
					{
						return new haxe.lang.Closure("rtrim", 1890696788, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 2085241678:
					{
						return new haxe.lang.Closure("ltrim", 2085241678, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 502018172:
					{
						return new haxe.lang.Closure("isSpace", 502018172, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 1538685534:
					{
						return new haxe.lang.Closure("endsWith", 1538685534, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 2043658359:
					{
						return new haxe.lang.Closure("startsWith", 2043658359, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 787326757:
					{
						return new haxe.lang.Closure("htmlUnescape", 787326757, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 681291596:
					{
						return new haxe.lang.Closure("htmlEscape", 681291596, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 89897469:
					{
						return new haxe.lang.Closure("urlDecode", 89897469, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
					}
					
					
					case 441601765:
					{
						return new haxe.lang.Closure("urlEncode", 441601765, ((haxe.lang.IHxObject) (StringTools.__hx_getClassStatic()) ));
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
					case 1095439090:
					{
						return StringTools.isEOF(haxe.lang.Runtime.toInt(dynargs[0]));
					}
					
					
					case 173105980:
					{
						return StringTools.fastCodeAt((( dynargs[0] + "" )), haxe.lang.Runtime.toInt(dynargs[1]));
					}
					
					
					case 5194459:
					{
						return StringTools.hex(haxe.lang.Runtime.toInt(dynargs[0]), haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 724060212:
					{
						return StringTools.replace((( dynargs[0] + "" )), (( dynargs[1] + "" )), (( dynargs[2] + "" )));
					}
					
					
					case 1203264615:
					{
						return StringTools.lpad((( dynargs[0] + "" )), (( dynargs[1] + "" )), haxe.lang.Runtime.toInt(dynargs[2]));
					}
					
					
					case 1269802017:
					{
						return StringTools.rpad((( dynargs[0] + "" )), (( dynargs[1] + "" )), haxe.lang.Runtime.toInt(dynargs[2]));
					}
					
					
					case 1292082402:
					{
						return StringTools.trim((( dynargs[0] + "" )));
					}
					
					
					case 1890696788:
					{
						return StringTools.rtrim((( dynargs[0] + "" )));
					}
					
					
					case 2085241678:
					{
						return StringTools.ltrim((( dynargs[0] + "" )));
					}
					
					
					case 502018172:
					{
						return StringTools.isSpace((( dynargs[0] + "" )), haxe.lang.Runtime.toInt(dynargs[1]));
					}
					
					
					case 1538685534:
					{
						return StringTools.endsWith((( dynargs[0] + "" )), (( dynargs[1] + "" )));
					}
					
					
					case 2043658359:
					{
						return StringTools.startsWith((( dynargs[0] + "" )), (( dynargs[1] + "" )));
					}
					
					
					case 787326757:
					{
						return StringTools.htmlUnescape((( dynargs[0] + "" )));
					}
					
					
					case 681291596:
					{
						return StringTools.htmlEscape((( dynargs[0] + "" )));
					}
					
					
					case 89897469:
					{
						return StringTools.urlDecode((( dynargs[0] + "" )));
					}
					
					
					case 441601765:
					{
						return StringTools.urlEncode((( dynargs[0] + "" )));
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
			baseArr.push("isEOF");
			baseArr.push("fastCodeAt");
			baseArr.push("hex");
			baseArr.push("replace");
			baseArr.push("lpad");
			baseArr.push("rpad");
			baseArr.push("trim");
			baseArr.push("rtrim");
			baseArr.push("ltrim");
			baseArr.push("isSpace");
			baseArr.push("endsWith");
			baseArr.push("startsWith");
			baseArr.push("htmlUnescape");
			baseArr.push("htmlEscape");
			baseArr.push("urlDecode");
			baseArr.push("urlEncode");
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
			return ((haxe.lang.Class) (( (( StringTools.__hx_class != default(haxe.lang.Class) )) ? (StringTools.__hx_class) : (StringTools.__hx_class = new haxe.lang.Class(new StringTools(haxe.lang.EmptyObject.EMPTY))) )) );
		}
	}
	
	
	public override   object __hx_createEmpty()
	{
		unchecked 
		{
			return new StringTools(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public override   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new StringTools();
		}
	}
	
	
}


