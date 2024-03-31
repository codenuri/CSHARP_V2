class Program
{
    public static void M1(int[] ar) { }
	public static void M2(params int[] ar) { }

    public static void Main()
    {
		M1(new int[] { 1, 2 });
		M1(new int[] { 1, 2, 3 });

		M1(new int[] { 1, 2, 3 });
		M1(new[] { 1, 2, 3 });
		M1([1, 2, 3]);
		M1(1,2,3);	// error
		M1();		// error

		M2(new int[] { 1, 2, 3 });
		M2(new[] { 1, 2, 3 });
		M2([1, 2, 3]);
		M2(1,2,3);	// ok
		M2();		// ok		
    }
    public static void M3(int[] ar, int n) { }			// ok
//	public static void M4(params int[] ar, int n) { }	// error

}
	