using static System.Console;

class Point3D
{
	private int x, y, z;

	public Point3D(int a, int b, int c) 
		=> (x, y, z) = (a, b, c);

	public void Deconstruct(out int a, 
							out int b, 
							out int c)
		=> (a, b, c) = (x, y, z);

}

class Program 
{
	public static void Main()
	{
		Point3D p = new Point3D(1,2,3);
	
//		(int a, int b, int c) = p; 

		p.Deconstruct(out int a, out int b, out int c);

		WriteLine($"{a}, {b}, {c}");		
	}
}