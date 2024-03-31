using static System.Console;

delegate bool MyPredicate<T>(T value);

class Program 
{
	public static int FindIndex<T>(T[] arr, 
							       MyPredicate<T> match)
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
		double[] x = {1.1, 2.2, 5.2, 3.2, 4.7 };

		int ret = FindIndex(x, Foo);
		WriteLine($"{ret}");	
	}

	public static bool Foo(double value)
		=> value > 4.1;
}
