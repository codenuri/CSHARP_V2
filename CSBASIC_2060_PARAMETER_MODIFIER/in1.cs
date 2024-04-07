using static System.Console;

class Program
{
	public static void M1(int n)     { n = 10; }
	public static void M2(ref int n) { n = 10; }

	public static void M3(in int n) 
	{
		int a = n; // ok
		 n = 10;   // error.
	}

	public static void Main()
	{
		int x = 0;
		M1(x);
		M2(ref x);
	//	M3(in x);
		M3(x);
	}
}
