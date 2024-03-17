using static System.Console;

partial class Example 
{
	partial void Init();
	partial void Run();
	partial void Exit();

	public void Process()
	{
		Init();
		Run();
		Exit();
	}
}
partial class Example 
{
	partial void Init() { WriteLine("Example Init"); }
//	partial void Run()  { WriteLine("Example Run"); }
	partial void Exit() { WriteLine("Example Exit"); }
}

class Program
{
	public static void Main()
	{
		Example e = new();
		e.Process();
	}
}