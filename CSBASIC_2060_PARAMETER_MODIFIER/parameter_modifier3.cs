using static System.Console;

class Program
{
	public static void no_modifier_parameter(int x)
	{
		int n = x;
		x = 0;
	}

	public static void out_parameter(out int x)
	{
//		int n = x;	// error
		x = 0;		// 이 코드가 없으면 error
	}

	public static void ref_parameter(ref int x)
	{
//		int n = x;	// ok
//		x = 0;		// ok
	}

	public static void Main()
	{
		int n1;
		int n2 = 0;

		out_parameter(out n1); // ok
		out_parameter(out n2); // ok
		ref_parameter(ref n1); // error
		ref_parameter(ref n2); // ok

		out_parameter(out int n3); // ok

		// 여기서 부터 n3 사용가능. 
	}
}