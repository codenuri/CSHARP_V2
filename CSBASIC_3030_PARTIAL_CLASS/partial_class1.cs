class Base
{
	public void BaseMethod() {}
}

partial class Example 
{
	public void Method() { BaseMethod(); }
}

partial class Example : Base
{
}

class Program 
{
	public static void Main()
	{
		Example e = new();
		e.Method();
	}
}