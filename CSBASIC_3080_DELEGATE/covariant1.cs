using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base 
{	
}

delegate R MyFunc<out R>();

class Program 
{
	public static Derived CreateDerived() => new Derived();

	public static void Main()
	{	
		MyFunc<Derived> f1 = CreateDerived;
		MyFunc<Base>    f2 = f1; // ?

		Base b = f2();
		b.Method();
	}
}
