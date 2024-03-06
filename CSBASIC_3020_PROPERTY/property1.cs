class Person1
{
    public int age;
}
class Person2
{
    private int age;    
    public int  GetAge(int a) => age;
    public void SetAge(int value) 
	{ 
		if ( value > 0 )
			age = value; 
	}
}
class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
		Person2 p2 = new Person2();
        
		p1.age = 10;
//		p1.age = -5;
		int n1 = p1.age;
	
        p2.SetAge(10);
		int n2 = p2.GetAge();
		p2.SetAge(-5);
    }
}
