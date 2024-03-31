using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base {}

interface ICovariant<out T>      {  T Create(); };
interface IContravariant<in T>   {	void Use(T obj); };

class Program 
{
	public static void Main()
	{	
		ICovariant<Derived> outderived = null!;
		ICovariant<Base>    outbase = outderived;

		IContravariant<Base> inbase = null!;
		IContravariant<Derived> inderived = inbase;
	}
}
