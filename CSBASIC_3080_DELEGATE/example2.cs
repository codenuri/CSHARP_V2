using static System.Console;

delegate bool MyFunc(int value);

class Program 
{
	public static int FindIndex(int[] arr, MyFunc match)
	{
		int sz = arr.Length;

		for( int i= 0; i < sz; i++)
		{
			if ( match( arr[i] ))
				return i;
		}
		return -1;
	}

	public static void Main()
	{
		int[] x = {1, 8, 6, 4, 3};

		int ret = FindIndex(x, Foo);
		WriteLine($"{ret}");	
	}

	public static bool Foo(int value)
		=> value % 3 == 0;
}