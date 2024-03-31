using System;
using static System.Console;

delegate void MyFunc(int arg);

class Program
{
	public static void Main()
	{
		MyFunc m1 = new MyFunc(Foo);
		MyFunc m2 = Foo;
		m1(10);			
		m2(10);	
	}

	public static void Foo(int arg) 
		=> WriteLine($"Foo : {arg}");
}
