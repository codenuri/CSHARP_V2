using static System.Console;

class Program
{
	public static void Main()
	{
//		int n = int.Parse("Hello");

		bool b = int.TryParse("Hello", out int n);

		WriteLine($"{b}, {n}");
					// False, 0
	}
}