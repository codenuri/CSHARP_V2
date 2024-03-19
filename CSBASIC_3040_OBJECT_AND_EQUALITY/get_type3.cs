using System;
using static System.Console;

class Program
{	
	public static void Foo(object obj)
	{
		// obj 가 int 인지 확인하고 싶다.

		Type t1 = obj.GetType();
		Type t2 = typeof(int);	

		WriteLine($"{t1 == t2}");
		WriteLine($"{obj is int}");			
	}

	public static void Main()
	{
		int n = 10;
		string s = "ABC";

		Foo(n);
		Foo(s);
	}
}