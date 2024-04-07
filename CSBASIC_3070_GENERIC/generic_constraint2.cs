#nullable disable
using System;
using static System.Console;

class Point
{
	public int X{set;get;} = 0;
	public int Y{set;get;} = 0;
	public Point(int x, int y) => (X, Y) = (x, y);
}

class Program
{
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {	
        return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    {
		Point p1 = new Point(1,1);
		Point p2 = new Point(2,2);

		WriteLine($"{Max(10, 20)}"); // ok
//		WriteLine($"{Max(p1, p2)}"); // error. 
    }
}
