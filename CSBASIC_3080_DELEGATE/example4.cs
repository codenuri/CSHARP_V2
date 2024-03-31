using static System.Console;

class Program 
{
	public static int MyCompare(int a, int b)
	{
//		return a.CompareTo(b);
		return b.CompareTo(a);
	}
	
	public static void Main()
	{
		int[] x = {1, 3, 5, 7, 9, 2, 4, 6, 8, 10};

//		Array.Sort(x);
		Array.Sort(x, MyCompare);

		foreach(var e in x)
			Write($"{e}, ");
	}

}

