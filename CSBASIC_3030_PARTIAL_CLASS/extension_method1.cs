using static System.Console;

class Example 
{
	public void Foo() => WriteLine("Example Foo");
}

static class ExampleExtension 
{
	public static void Goo( this Example e, int a)
		=> WriteLine("Example Goo {0}", a);
}

class Program
{
	public static void Main()
	{
		Example e = new();
		e.Foo();
		e.Goo(3);
	}
}
