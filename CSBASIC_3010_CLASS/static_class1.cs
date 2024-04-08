using static System.Console;

static class Math 
{
	public static int Max(int a, int b) 
		=> a < b ? b : a;

	public static int Min(int a, int b) 
		=> a < b ? a : b;
}

class Program 
{
	public static void Main()
	{
		WriteLine($"{Math.Max(1, 3)}");
		WriteLine($"{Math.Min(1, 3)}");

//		Math m1 = new Math(); 
//		Math m2;
	}
}