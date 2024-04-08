using System;

class Program 
{
	public static void Main()
	{
		var ret = Math.Max(3.4, 2.1);

		Console.WriteLine($"{ret}");

		Math    m = new Math();	// error
		Console c = new Console();// error
	}
}