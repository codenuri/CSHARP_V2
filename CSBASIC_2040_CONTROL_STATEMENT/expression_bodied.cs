class Point
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => ( x, y) = (a, b);
	public int  GetY() =>  y;
	public void SetY(int value) => y = value;
}

class Program 
{
	public static void Main()
	{
		Point p = new Point(1,2);
		p.SetY(3);
		var n = p.GetY();
	}
}

