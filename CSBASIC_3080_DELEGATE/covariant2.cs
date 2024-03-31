using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base 
{	
}

delegate Base    DBase();
delegate Derived DDerived();

class Program 
{
	public static Derived CreateDerived() => new Derived();

	public static void Main()
	{	
		DDerived f1 = CreateDerived;
		DBase    f2 = f1;	// error

		Base b2 = f2();
		b2.Method();
	}
}
