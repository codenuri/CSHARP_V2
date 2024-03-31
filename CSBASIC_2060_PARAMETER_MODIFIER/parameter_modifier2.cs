using static System.Console;

class Program
{
	public static int AddSub(int a, int b, out int ret)
	{
		ret = a - b;
		return a + b;
	}

	public static void Main()
	{
//		int ret1 = 0;
		int ret1;

		int ret2 = AddSub(5, 3, out ret1);

		WriteLine($"{ret1}, {ret2}");
				//   2,      8
	}
}