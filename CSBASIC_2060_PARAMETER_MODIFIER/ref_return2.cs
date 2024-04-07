using static System.Console;

class MyCollection
{
	private int[] data = { 1, 2, 3, 4, 5};

	public ref int At(int idx) { return ref data[idx];}

	public void Show() 
	{
		foreach(int e in data)
			Write($"{e}, ");
		WriteLine("");
	}
}

class Program 
{
	public static void Main()
	{
		MyCollection mc = new MyCollection();
		mc.At(0) = 9; // mc[0] = 9
		mc.At(1) = 7;
		mc.Show(); // 9, 7, 3, 4, 5, 
	}
}