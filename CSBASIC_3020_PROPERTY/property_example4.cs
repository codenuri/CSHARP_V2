using static System.Console;

class Person
{
	private int age;

	public int Age 
	{
		get => age;
		set => age = value;		
	}
	
	public bool IsAdult
	{
		get => Age > 18;
	}


	private string firstName = null!;
	private string lastName = null!;

	public required string FirstName 
	{
		get => firstName;
		set => firstName = value;
	}
	public required string LastName 
	{
		get => lastName;
		set => lastName = value;
	}

	public string FullName 
	{
		get => $"{FirstName} {LastName}";
	}
}
class Program 
{
	public static void Main()
	{
		Person p = new Person{FirstName = "Susan",
							  LastName = "Connor",
							  Age = 20};

		WriteLine($"{p.FullName}, {p.IsAdult}");
	}
}
