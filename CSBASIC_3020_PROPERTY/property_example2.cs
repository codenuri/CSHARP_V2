class Example2
{
    private int data1 = 0;
    private int data2 = 0;

    public int Data1
	{   
		get => data1;
		set => data1 = value;
    }

    public int Data2 
	{
		get => data2;
//		set => data1 = value;
		init => data2 = value;
    }


    public Example2()
    {
		Data1 = 0;  // ok
		Data2 = 0;	// ok
    }
}

class Program
{
    public static void Main()
    {
        Example2 e1 = new Example2{ Data1 = 0, 	// ok
									Data2 = 0 };// ok
		e1.Data1 = 0;	// ok
//		e1.Data2 = 0;	// error
    }
}
