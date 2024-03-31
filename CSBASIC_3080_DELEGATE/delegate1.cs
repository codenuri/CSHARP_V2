using System;
using static System.Console;

delegate void MyFunc(int arg);

class Program
{
	public static void Main()
	{
		int    n = 10;
		double d = 3.4;
		string s = "abc";	

		MyFunc f = Foo;
		f(10);			// Foo(10)
		f.Invoke(10);	// Foo(10)
	}

	public static void Foo(int arg) 
		=> WriteLine($"Foo : {arg}");
}
