
namespace haxe
{
	public  class Int64 
	{
		public static   long make(int high, int low)
		{
			unchecked 
			{
				return ((long) (( ( ((long) (high) ) << 32 ) | ((long) (low) ) )) );
			}
		}
		
		
		public static   long ofInt(int x)
		{
			unchecked 
			{
				return ((long) (x) );
			}
		}
		
		
		public static   long ofInt32(int x)
		{
			unchecked 
			{
				return ((long) (x) );
			}
		}
		
		
		public static   int toInt(long x)
		{
			unchecked 
			{
				return ((int) (x) );
			}
		}
		
		
		public static   int getLow(long x)
		{
			unchecked 
			{
				return ((int) (x) );
			}
		}
		
		
		public static   int getHigh(long x)
		{
			unchecked 
			{
				return ((int) (((int) (( ((uint) (((long) (x) )) ) >> 32 )) )) );
			}
		}
		
		
		public static   long @add(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) + ((long) (b) ) )) );
			}
		}
		
		
		public static   long sub(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) - ((long) (b) ) )) );
			}
		}
		
		
		public static   long mul(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) * ((long) (b) ) )) );
			}
		}
		
		
		public static   object divMod(long modulus, long divisor)
		{
			unchecked 
			{
				long q = ( ((long) (modulus) ) / ((long) (divisor) ) );
				long m = ((long) (( ((long) (modulus) ) % ((long) (divisor) ) )) );
				return new haxe.lang.DynamicObject(new Array<int>(new int[]{}), new Array<object>(new object[]{}), new Array<int>(new int[]{845179051, 2012934199}), new Array<double>(new double[]{q, m}));
			}
		}
		
		
		public static   long div(long a, long b)
		{
			unchecked 
			{
				return ( ((long) (a) ) / ((long) (b) ) );
			}
		}
		
		
		public static   long mod(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) % ((long) (b) ) )) );
			}
		}
		
		
		public static   long shl(long a, int b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) << b )) );
			}
		}
		
		
		public static   long shr(long a, int b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) >> b )) );
			}
		}
		
		
		public static   long ushr(long a, int b)
		{
			unchecked 
			{
				return ((long) (((int) (( ((uint) (((long) (a) )) ) >> b )) )) );
			}
		}
		
		
		public static   long and(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) & ((long) (b) ) )) );
			}
		}
		
		
		public static   long or(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) | ((long) (b) ) )) );
			}
		}
		
		
		public static   long xor(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) ^ ((long) (b) ) )) );
			}
		}
		
		
		public static   long neg(long a)
		{
			unchecked 
			{
				return ((long) ( - (((long) (a) )) ) );
			}
		}
		
		
		public static   bool isNeg(long a)
		{
			unchecked 
			{
				return ( ((long) (a) ) < ((long) (0) ) );
			}
		}
		
		
		public static   bool isZero(long a)
		{
			unchecked 
			{
				return ( ((long) (a) ) == ((long) (0) ) );
			}
		}
		
		
		public static   int compare(long a, long b)
		{
			unchecked 
			{
				return ((int) (( ((long) (a) ) - ((long) (b) ) )) );
			}
		}
		
		
		public static   int ucompare(long a, long b)
		{
			unchecked 
			{
				long a1 = ((long) (a) );
				long b1 = ((long) (b) );
				if (( a1 < ((long) (0) ) )) 
				{
					return ( (( b1 < ((long) (0) ) )) ? (((int) (( ((long) ( ~ (a1) ) ) - ((long) ( ~ (b1) ) ) )) )) : (1) );
				}
				
				return ( (( b1 < ((long) (0) ) )) ? (-1) : (((int) (( ((long) (a1) ) - ((long) (b1) ) )) )) );
			}
		}
		
		
		public static   string toStr(long a)
		{
			unchecked 
			{
				return ( a + "" );
			}
		}
		
		
	}
}


