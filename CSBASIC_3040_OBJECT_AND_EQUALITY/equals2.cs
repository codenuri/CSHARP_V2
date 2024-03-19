using static System.Console;

class Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);

	public override bool Equals(object? obj)
	{
		if ( obj == null || !(obj is Point) )
		 	return false;

		Point p = (Point)obj;
		
    	return x == p.x && y == p.y;
	}	
	public override int GetHashCode() 
	{
		return x.GetHashCode() + y.GetHashCode();
	}	
}

class Program
{
	public static void Main() 
	{
		Point p1 = new Point(1,2);
		Point p2 = p1;
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		WriteLine($"{p1 == p2} {p3 == p4}"); 
					// True,    False

		WriteLine($"{p1.Equals(p2)} {p3.Equals(p4)}");
					// True,    True

	}
}
