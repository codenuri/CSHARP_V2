using static System.Console;

class Program
{
	public static void M1(ref readonly int n)     
	{ 
		int a = n; 	// ok
		n = 10; 	// error
	}

	public static void Main()
	{
		int x = 0;
		M1(ref x);
	}
}
