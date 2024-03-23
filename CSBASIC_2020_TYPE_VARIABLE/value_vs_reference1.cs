using static System.Console;

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()
	{
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);	
	}
}
