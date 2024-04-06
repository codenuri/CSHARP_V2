class Person1
{
	public int Age = 0;
}
class Person2
{
	public int Age {set; get;} = 0;
}
class Program 
{
	public static void Main()
	{
		Person1 p1 = new();
		Person1 p2 = new();

		p1.Age = 10;		
		p2.Age = 10;
		p1.Age = -5;		
		p2.Age = -5;
	}
}