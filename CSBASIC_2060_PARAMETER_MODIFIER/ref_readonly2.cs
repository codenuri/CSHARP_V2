class Program
{
	static void M1(ref int n) {} // C# 1.0 

	static void M2(in int n)  {} // C# 7.2  
	
	static void M3(ref readonly int r)  {} // C# 12.0 
	
	public static void Main()
	{
		int x = 0;

		ref int r1 = ref x;				// C# 7.0
		
		ref readonly int r2 = ref x;	// C# 7.2

	}
}
