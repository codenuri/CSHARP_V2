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
		int n1 = 10;
		int n2 = 10;

		Point p1 = new Point(1, 2);
//		Point p2 = new Point(1, 2);			
		Point p2 = p1;	// 다른 객체

//		WriteLine($"{p1 == p2}"); // error
		WriteLine($"{n1 == n2}"); // ok

		WriteLine($"{p1.Equals(p2)}"); // True
		WriteLine($"{n1.Equals(n2)}"); // True
	}
}
