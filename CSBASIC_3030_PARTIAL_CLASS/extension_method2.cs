class Example { public void M1() {} }

static class MyExtension 
{
	public static void M2( this Example obj ) {}
	public static void M3( Example obj ) {}
}

class Program
{
	public static void Main()
	{
		Example e = new();
		e.M1();

		MyExtension.M2(e); // ok
		MyExtension.M3(e); // ok

		e.M2();	// ok 
//		e.M3(); // error

	}
}
