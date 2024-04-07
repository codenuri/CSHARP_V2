class Point<T>
{
//	private T x = 0;
//	private T y = 0;

//	private T x = default;
//	private T y = default(T);

	private T x;
	private T y;

	public Point(T a, T b)
	{
		x = a;
		y = b;
	}
}

class Program
{
    public static void Main()
    {
		Point<int> p1 = new Point<int>(1, 2);
		var p2 = new Point<double>(1.1, 2.2);
    }
}