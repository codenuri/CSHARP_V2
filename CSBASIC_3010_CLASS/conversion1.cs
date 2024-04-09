class Point3D
{
	private int x = 0;
	private int y = 0;
	private int z = 0;

	public Point3D(int a, int b, int c) 
		=> (x, y, z) = (a, b, c);

	public static implicit operator int(Point3D p) 
		=> p.x;

//	public static implicit operator Point3D(int x) 
	public static explicit operator Point3D(int x) 
		=> new Point3D(x, 0, 0);
}

class Program 
{
	public static void Main()
	{
		Point3D p = new Point3D(1,2,3);

		int x = p;
//		p = x;
		p = (Point3D)x;
	}
}