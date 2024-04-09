using static System.Console;

class Point3D
{
	private int x, y, z;

	public Point3D(int a, int b, int c) 
		=> (x, y, z) = (a, b, c);

	public void Deconstruct(out int a, out int b, out int c)
		=> (a, b, c) = (x, y, z);

	public void Deconstruct(out int a, out int b)
		=> (a, b) = (x, y);

	public void Deconstruct(out int a)
		=> a = x;		
}

class Program 
{
	public static void Main()
	{
		Point3D p = new Point3D(1,2,3);
	
		(int a1, int a2, int a3) = p; 

		(int b1, int b2) = p; 

//		(int c1) = p;
//		int c1 = p;
		p.Deconstruct(out int c);
	}
}