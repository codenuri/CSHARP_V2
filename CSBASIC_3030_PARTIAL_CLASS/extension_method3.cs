using static System.Console;

static class MyExtensions
{
	public static int WordCount(this string s)
	{
		return s.Split(new char[] { ' ', '.', '?' },
		StringSplitOptions.RemoveEmptyEntries).Length;
	}
}

class Program
{
	public static void Main()
	{
		string s = "to be or not to be";

		int wc = s.WordCount(); // MyExtensions.WordCount(s)

		WriteLine(wc);
	}
}
