using static System.Console;

class Program
{
	public static void Inc(ref int x)
	{
		++x;
	}

	public static void Main()
	{
		int n = 0;
		Inc(ref n);

		WriteLine(n); // 0 ? 1

		ref int r = ref n;
		r = 20;
		WriteLine(n); // 20
	}
}