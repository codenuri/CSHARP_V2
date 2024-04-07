using static System.Console;

class Point 
{
	public int x = 0;
	public int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
	public static void Foo(in Point p)
	{
		p.x = 2;		// ok
		p = new Point(3, 3); // error
	}
    public static void Main(string[] args)
    {
		Point pt = new Point(1, 1);
		Foo(pt);
		WriteLine($"{pt.x}");
    }

}