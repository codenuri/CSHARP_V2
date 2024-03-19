using System;
using static System.Console;

class Program
{
	public static void PrintType(object obj)
	{
		Type t = obj.GetType();	
		WriteLine($"{t.Name}, {t.FullName}");	
			
		Type bt = t.BaseType;
		WriteLine($"{bt.Name}, {bt.FullName}");				
	}

	public static void Main()
	{
		string s = "ABC";
		int    n = 10;
		PrintType(s);
		PrintType(n);
	}
}
