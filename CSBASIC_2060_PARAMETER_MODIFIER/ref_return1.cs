using static System.Console;

class Example
{
	public int data = 0;
	public int GetValue() { return data; }
	public ref int GetReference() { return ref data;}
}
class Program 
{
	public static void Main()
	{
		Example e = new Example();

		int ret1 = e.GetValue();
		ref int ret2 = ref e.GetReference();

		ret1 = 3;	WriteLine($"{e.data}"); // 0
		ret2 = 3; 	WriteLine($"{e.data}"); // 3

		e.GetReference() = 5;	WriteLine($"{e.data}");//5
	}
}