class Person
{	
	public string Name{ get;}
	public string Address{ get; set; }

	public Person(string name, string address)
	{
		Name    = name;		// 핵심. get-only 지만
							// 생성자에서는 쓰기 가능.
		Address = address;
	}
}

class Program 
{
	public static void Main()
	{
		Person p = new Person("kim", "seoul");

//		p.Name = "lee";		// error
		p.Address = "jeju";	// ok		
	}
}