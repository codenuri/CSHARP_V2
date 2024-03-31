using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
		MyFunc f1 = Program.SMethod;  // ok
		MyFunc f2 = SMethod;		  // ok	  
//		MyFunc f3 = IMethod;  // error

		Program p = new Program();		  
		MyFunc f4 = p.IMethod;	// ok

		p.InstanceMethod();
	}

	public void InstanceMethod()
	{
		MyFunc f1 = Program.SMethod;  // ok
		MyFunc f2 = SMethod;		  // ok	  
		MyFunc f3 = this.IMethod;	  // ok	  
		MyFunc f4 = IMethod;	      // ok		
	}
}
