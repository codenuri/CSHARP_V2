partial class Example1 {}
partial class Example1 {}	// ok

partial struct Example2 {}
partial struct Example2 {}	// ok

partial record Example3 {}
partial record Example3 {}	// ok

partial interface Example4 {}
partial interface Example4 {}	// ok

//partial enum Example5 {}
//partial enum Example5 {} 	// error

class Program
{
	public static void Main() { }
}