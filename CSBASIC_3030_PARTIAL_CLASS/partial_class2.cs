interface IFoo { void Foo();}
interface IGoo { void Goo();}

partial class Example : IFoo 
{
	public void Goo() {}
}

partial class Example : IGoo 
{
	public void Foo() {}
}

class Program 
{
	public static void Main()
	{
		Example e = new();
		e.Foo();
		e.Goo();
	}
}
