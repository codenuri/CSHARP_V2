class Person
{
    private int age = 0;    

    public  int Age 
	{
		set { age = value; }
		get { return age; }		
    }
	/*
	public void set_Age(int value) // error
	{
		age = value;
	}
	*/
}

class Program
{
    public static void Main()
    {
        Person p = new Person();

		p.Age = 10;	
		int n1 = p.Age;			
    }
}
