using static System.Console;

class Program
{
    public static void M1(int a, int b = 0, int c = 0)
	{
	 	WriteLine($"{a}, {b}, {c}");
	} 
    public static void Main()
    {
        M1(10, 20, 30); // 10, 20, 30
        M1(10, 20);	 	// 10, 20, 0
        M1(10);         // 10, 0,  0

		M1(10, c:20); 	// 10, 0, 20
    }
    // 주의!
    // Optional parameter 뒤에 Require parameter 를 만들수 없다.
    public static void M2(int a, int b = 0, int c = 0) { }  // ok
//  public static void M3(int a = 0, int b, int c = 0) { }  // error
//  public static void M4(int a, int b = 0, int c) { }      // error
}