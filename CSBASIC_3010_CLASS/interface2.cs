using static System.Console;

class Label : IComparable
{
	private string title;
	
	public Label(string s) => title = s;

	public int CompareTo(object? obj)
	{
		Label? lb = obj as Label;
		return title.CompareTo(lb?.title);
	}
}

class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");

		int ret = d1.CompareTo(d2);

		Foo(d1);
	}
	public static void Foo(IComparable ic)
	{
	}
}

