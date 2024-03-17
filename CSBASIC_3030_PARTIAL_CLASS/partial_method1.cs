using static System.Console;

partial class Example 
{
	public void Process()
	{
		Init();
		Run();
		Exit();
	}
}
partial class Example 
{
	void Init() { WriteLine("Example Init"); }
//	void Run()  { WriteLine("Example Run"); }
	void Exit() { WriteLine("Example Exit"); }
}
class Program
{
	public static void Main()
	{
		Example e = new();
		e.Process();
	}
}