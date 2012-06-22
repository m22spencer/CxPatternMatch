
namespace haxe.lang
{
	public  interface Iterator<T> : haxe.lang.IHxObject, haxe.lang.Iterator 
	{
		   object haxe.lang.Iterator.cast<T1>();
		
		   bool hasNext();
		
		   T next();
		
	}
}



namespace haxe.lang
{
	public  interface Iterator : haxe.lang.IHxObject 
	{
		   object cast<T1>();
		
	}
}



namespace haxe.lang
{
	public  interface Iterable<T> : haxe.lang.IHxObject, haxe.lang.Iterable 
	{
		   object haxe.lang.Iterable.cast<T1>();
		
		   object iterator();
		
	}
}



namespace haxe.lang
{
	public  interface Iterable : haxe.lang.IHxObject 
	{
		   object cast<T1>();
		
	}
}


