class Person
{	
	public string Name{ get; private set;}
	public string Address{ get; set; }

	public void SetName(string name) => Name = name;

	public Person(string name, string address)
	{
		Name    = name;
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
		p.SetName("lee");	// ok	
	}
}