using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base {}

delegate void MyAction<in T>(T obj);

class Program 
{
	public static void UseBase(Base b) { b.Method(); }

	public static void Main()
	{	
		MyAction<Base>    f1 = UseBase;
		MyAction<Derived> f2 = f1;

		f2(new Derived());
	}
}