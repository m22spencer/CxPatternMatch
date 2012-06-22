
public  class Std 
{
	public static   bool @is(object v, object t)
	{
		unchecked 
		{
			haxe.lang.Class clt = ((haxe.lang.Class) (t) );
			if (( clt == default(haxe.lang.Class) )) 
			{
				return false;
			}
			
			System.Type native = ((System.Type) (haxe.lang.Runtime.callField(clt, "nativeType", 337182705, default(Array))) );
			return native.IsAssignableFrom(cs.Lib.getNativeType(v));
		}
	}
	
	
	public static   string @string(object s)
	{
		unchecked 
		{
			return (( s + "" ));
		}
	}
	
	
	public static   int @int(double x)
	{
		unchecked 
		{
			return ((int) (x) );
		}
	}
	
	
	public static   haxe.lang.Null<int> parseInt(string x)
	{
		unchecked 
		{
			if (string.Equals(x, default(string))) 
			{
				return default(haxe.lang.Null<int>);
			}
			
			int ret = 0;
			int @base = 10;
			int i = -1;
			if (((bool) (x.StartsWith("0x")) )) 
			{
				i = 1;
				@base = 16;
			}
			
			int len = x.Length;
			bool foundAny = false;
			bool isNeg = false;
			while ((  ++ i < len ))
			{
				int c = haxe.lang.Runtime.toInt(x[i]);
				if ( ! (foundAny) ) 
				{
					switch (c)
					{
						case 45:
						{
							isNeg = true;
							continue;
						}
						
						
						case 32:case 9:case 10:case 13:
						{
							if (isNeg) 
							{
								return default(haxe.lang.Null<int>);
							}
							
							continue;
						}
						
						
					}
					
				}
				
				if (( ( c >= 48 ) && ( c <= 57 ) )) 
				{
					if ((  ! (foundAny)  && ( c == 48 ) )) 
					{
						foundAny = true;
						continue;
					}
					
					ret *= @base;
					foundAny = true;
					ret += ( c - 48 );
				}
				 else 
				{
					if (( @base == 16 )) 
					{
						if (( ( c >= 97 ) && ( c <= 102 ) )) 
						{
							ret *= @base;
							foundAny = true;
							ret += ( ( c - 97 ) + 10 );
						}
						 else 
						{
							if (( ( c >= 65 ) && ( c <= 70 ) )) 
							{
								ret *= @base;
								foundAny = true;
								ret += ( ( c - 65 ) + 10 );
							}
							 else 
							{
								break;
							}
							
						}
						
					}
					 else 
					{
						break;
					}
					
				}
				
			}
			
			if (foundAny) 
			{
				return new haxe.lang.Null<int>(( (isNeg) ? ( - (ret) ) : (ret) ), true);
			}
			 else 
			{
				return default(haxe.lang.Null<int>);
			}
			
		}
	}
	
	
	public static   double parseFloat(string x)
	{
		unchecked 
		{
			if (string.Equals(x, default(string))) 
			{
				return Math.NaN;
			}
			
			x = x.TrimStart();
			double ret = 0.0;
			double div = 0.0;
			double e = 0.0;
			int len = x.Length;
			bool foundAny = false;
			bool isNeg = false;
			int i = -1;
			while ((  ++ i < len ))
			{
				int c = haxe.lang.Runtime.toInt(x[i]);
				if ( ! (foundAny) ) 
				{
					switch (c)
					{
						case 45:
						{
							isNeg = true;
							continue;
						}
						
						
						case 32:case 9:case 10:case 13:
						{
							if (isNeg) 
							{
								return Math.NaN;
							}
							
							continue;
						}
						
						
					}
					
				}
				
				if (( c == 46 )) 
				{
					if (( div != 0.0 )) 
					{
						break;
					}
					
					div = 1.0;
					continue;
				}
				
				if (( ( c >= 48 ) && ( c <= 57 ) )) 
				{
					if ((  ! (foundAny)  && ( c == 48 ) )) 
					{
						foundAny = true;
						continue;
					}
					
					ret *= 10;
					foundAny = true;
					div *= 10;
					ret += ( c - 48 );
				}
				 else 
				{
					if (( foundAny && (( ( c == 101 ) || ( c == 69 ) )) )) 
					{
						bool eNeg = false;
						bool eFoundAny = false;
						if (( ( i + 1 ) < len )) 
						{
							int next = ((int) (x[( i + 1 )]) );
							if (( next == 45 )) 
							{
								eNeg = true;
								i++;
							}
							 else 
							{
								if (( next == 43 )) 
								{
									i++;
								}
								
							}
							
						}
						
						while ((  ++ i < len ))
						{
							c = ((int) (x[i]) );
							if (( ( c >= 48 ) && ( c <= 57 ) )) 
							{
								if ((  ! (eFoundAny)  && ( c == 48 ) )) 
								{
									continue;
								}
								
								eFoundAny = true;
								e *= 10;
								e += ( c - 48 );
							}
							 else 
							{
								break;
							}
							
						}
						
						if (eNeg) 
						{
							e =  - (e) ;
						}
						
					}
					 else 
					{
						break;
					}
					
				}
				
			}
			
			if (( div == 0.0 )) 
			{
				div = 1.0;
			}
			
			if (foundAny) 
			{
				ret = ( (isNeg) ? ( - ((( ret / div ))) ) : (( ret / div )) );
				if (( e != 0.0 )) 
				{
					return ( ret * System.Math.Pow(10.0, e) );
				}
				 else 
				{
					return ret;
				}
				
			}
			 else 
			{
				return Math.NaN;
			}
			
		}
	}
	
	
	public static   int random(int x)
	{
		unchecked 
		{
			return Math.rand.Next(x);
		}
	}
	
	
}


