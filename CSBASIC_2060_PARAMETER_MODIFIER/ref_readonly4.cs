struct SevenSegment
{
	private int number = 0;
	public SevenSegment(int n) => number = n;

    public static implicit operator SevenSegment(int n)
	 	=> new SevenSegment(n);
}

class Program 
{
	static void M1(SevenSegment s) {}
	static void M2(ref SevenSegment s) {}
	static void M3(ref readonly SevenSegment s) {}
	static void M4(in SevenSegment s) {}
	
	public static void Main()
	{
		M1(7);			// ok
		M2(ref 7);		// error
		M3(ref 7);		// error
		M4(7);			// 
	}
}