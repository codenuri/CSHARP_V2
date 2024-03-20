using static System.Console;

class Point 
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;
	public Point(int a, int b) => (X, Y) = (a, b);
}
class Program
{
	public static void Main()
	{
		Point p1 = new Point(1, 1);
		object o = p1;
		Point p2 = (Point)o;
		p1.X = 2; 
		p1.Y = 2;
		Console.WriteLine($"{p2.X}, {p2.Y}");
						// class  : 2, 2
						// struct : 1, 1

	}
}