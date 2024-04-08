using static System.Console;

class Animal
{
    public         void Cry1() { WriteLine("1. Animal Cry1");}
	public virtual void Cry2() { WriteLine("1. Animal Cry2");}
}
class Dog : Animal
{
    public new      void Cry1() { WriteLine("2. Dog Cry1");}
	public override void Cry2() { WriteLine("2. Dog Cry2");}
}
class Program
{
    public static void Main()
    {
		Animal ad = new Dog();
		ad.Cry1();  // static binding
		ad.Cry2();  // dynamic binding
	}
}

