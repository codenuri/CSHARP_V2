using static System.Console;

struct Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
	public static void Main() 
	{
		Point p1 = new Point(1, 1);
		Point p2 = new Point(2, 2);

		WriteLine($"{object.Equals(p1, p2)}"); // False
		WriteLine($"{object.Equals(p1, p1)}"); // True	

		WriteLine($"{object.ReferenceEquals(p1, p2)}");
		WriteLine($"{object.ReferenceEquals(p1, p1)}");
	}
}
