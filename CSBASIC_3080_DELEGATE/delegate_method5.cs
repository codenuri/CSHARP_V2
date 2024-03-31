delegate void MyFunc(int arg);

class Program
{
	public static void M1(int arg)    {}
	
	public static void Main()
	{
		MyFunc f = M1;

		f(10);
		f.Invoke(10);

		if ( f != null )
			f(10);

//		f?(10);			// error
		f?.Invoke(10);  // ok
	}
}
