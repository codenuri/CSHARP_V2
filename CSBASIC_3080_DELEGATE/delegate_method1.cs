using static System.Console;

delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) 	
		=> WriteLine("Test.SMethod");

    public void IMethod(int arg)
		=> WriteLine("Test_Object.IMethod");
}

class Program
{
    public static void Main()
    {
		MyFunc f1 = Test.SMethod;

		Test t = new Test();
		MyFunc f2 = t.IMethod;

		f1(10);
		f2(20);
	}
}
