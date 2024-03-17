partial class Example 
{
	private partial void Foo();      

	public void Process()
	{
//		int ret = Foo(); // ret 때문에 Foo 호출 생략 안됨
//		... using ret

		Foo();
	}
}
partial class Example 
{
//	private partial void Foo() { }	
}

class Program
{
	public static void Main()
	{
		Example e = new();
		e.Process();
//		e.Foo();
	}
}