using static System.Console;

class CPoint
{
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }	
}

class Program 
{
	public static void Main()
	{
		CPoint cp1;
		SPoint sp1;
		SPoint sp2 = new SPoint(1, 1);
		
		int a = cp1.x;	// error
		cp1.x = 2;		// error

		int b = sp1.x;	// error
		sp1.x = 2;		// ok
		int c = sp1.x;	// ok

		int d = sp2.x;	// ok
		sp2.x = 2;		// ok

	}
}
