class Person
{	
	public required string Name{ get; init; }
	public required string Address{ get; set; }
}

class Program 
{
	public static void Main()
	{
		Person p = new Person{Name="kim", Address="seoul"};
		
//		p.Name = "lee"; // error
		p.Address = "jeju"; // ok
	}
}