class Example1
{
    private int data1 = 0;
    private int data2 = 0;
    private int data3 = 0;
    private int data4 = 0;
    private int data5 = 0;

    public int Data1
	{   
		get { return data1; }	
		set { data1 = value; }
    }

    public int Data2 
	{
		get => data2;
		set => data2 = value;
    }

	public int Data3
	{   
		get => data3; 			// get_Data3()
    }
    public int Data4 
	{
        set => data4 = value; 	// set_Data4()
    }

    public int Data5 
	{
        get => data5;
        private set => data5 = value;
    }

    public Example1()
    {
//		data5 = 10;
        Data5 = 10;	// ok
    }	
}

class Program
{
    public static void Main()
    {
        Example1 e1 = new();
//		e1.Data5 = 10;	// error
    }
}
