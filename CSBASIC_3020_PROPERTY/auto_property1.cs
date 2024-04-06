class Example
{
    private int data1 = 0;

    public int Data1
    {
        set => data1 = value;
        get => data1;
    }	

	public int Data2 { set; get; } = 0;	
}

class Program
{
    public static void Main()
    {
        Example e = new Example();
        e.Data1 = 10;
		e.Data2 = 10;

    }
}
