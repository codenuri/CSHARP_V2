using static System.Console;

class Program 
{
	public static bool Foo(int value)
	{
		return value % 3 == 0;
	}
	public static void Main()
	{
		int[] x = {1, 8, 6, 4, 3};

		int ret1 = Array.IndexOf(x, 3);		
		WriteLine($"{ret1}");  // 4


		int ret2 = Array.FindIndex(x, Foo);
		WriteLine($"{ret2}");	// 2			
	}

}