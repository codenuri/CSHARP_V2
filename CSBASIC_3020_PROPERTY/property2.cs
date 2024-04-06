class Person
{
    private int age = 0;    

    public  int Age 
	{
		get { return age; }
		set { if ( value > 0 ) age = value; }
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

		p1.Age = 10;		// set {} 호출
		int n1 = p1.Age;	// get {} 호출
    }
}
