using static System.Console;

class Program 
{
	public static void Main()
	{
		int x = 0;
		int y = 0;

//		int alias = x;
		ref int alias = ref x;
		alias = 3;
		
		WriteLine($"{x}, {y}");	// 3, 0

		alias = y;
		WriteLine($"{x}, {y}");	// 0, 0
		
		alias = ref y;
		alias = 5;
		WriteLine($"{x}, {y}");	// 0, 5

		ref readonly int ro_alias = ref x;
		WriteLine($"{ro_alias}"); // 0
//		ro_alias = 30;	// error
	}
}