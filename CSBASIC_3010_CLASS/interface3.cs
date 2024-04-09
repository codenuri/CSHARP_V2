using static System.Console;

class Label : IComparable, 	ICloneable
{
	private string title;
	public Label(string s) => title = s;

	public int CompareTo(object? obj)
	{
		Label? lb = obj as Label;
		return title.CompareTo(lb?.title);
	}
	
	public object Clone() => new Label(title);
}

class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = d1;

		Label d3 = (Label)d1.Clone();
	}
}
