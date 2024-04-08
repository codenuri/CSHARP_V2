using static System.Console;

class Train
{
	public Train() { WriteLine("Train()"); }
	static Train() { WriteLine("static Train()"); }
}

class Program 
{
	public static void Main()
	{
		// Train t1 = new Train();
		// Train t2 = new Train();
		// Train t3 = new Train();
	}
}