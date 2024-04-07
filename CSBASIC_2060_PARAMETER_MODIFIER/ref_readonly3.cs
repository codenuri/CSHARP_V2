class Program
{
	public static void M1(int n) {}
	public static void M2(ref int n) {}
	public static void M3(ref readonly int n) {}
	public static void M4(in int n) {}

	public static void Main()
	{
		int x = 3;
		M1(x); M2(ref x); M3(ref x); M4(x); // ok
		
		M1(3);		// ok
		M2(ref 3);	// error
		M3(ref 3);	// error
		M4(3);		// 
	}
}
