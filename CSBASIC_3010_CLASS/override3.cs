using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}
class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry");}
}

class Program
{
    public static void Main()
    {
		Animal ad = new Dog();

//		if ( 실행시간에_사용자가_입력한 값 == 1 )
//			ad = new Animal();

		ad.Cry();  
	}
}

