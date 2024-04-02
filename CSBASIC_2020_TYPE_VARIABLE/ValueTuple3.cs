using static System.Console;

class Point
{
	public int x = 0;
	public int y = 0;

	public Point(int a, int b)
	{
//		x = a;
//		y = b;

		(x, y) = (a, b); // deconstruction

//		(int x, int y) t = (a, b); // tuple 객체 t를 생성
	}

	public (int x, int y) Get()
	{
		return (x, y);
	}
}

class Program 
{
	public static void Main()
	{
		Point p = new Point(1,2);

		var ret = p.Get();		// ret 는 ValueTuple, 멤버이름 x, y

		(int x, int y) = p.Get();

		WriteLine($"{ret.x} {ret.y}");
		WriteLine($"{x} {y}");
	}
}
