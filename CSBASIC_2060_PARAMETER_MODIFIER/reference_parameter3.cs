using static System.Console;

class Point 
{
	public int x = 0;
	public int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);
}

class Program 
{
	public static void RefModifier(ref Point pt)
	{
		pt.x = 3;
		pt = new Point(2, 2);
	}	
	public static void Main()
	{
		Point p = new Point(1, 1);

		RefModifier(ref p);

		WriteLine($"{p.x} {p.y}");	
	}
}