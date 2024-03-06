class Example
{
    private int data1 = 0;
	private int data2 = 0;


	public int Data1 { set => data1 = value; }	
    public int Data2 { get => data2;  }	
	

//	public int Data3 { set; } = 0;	// error
	public int Data4 { get; } = 0;	


	public Example(int a, int b)
	{
//		Data2 = a;	// error. get-only
		data2 = a;  // ok. 필드이름으로 초기화.

		Data4 = a;  // ok. 
	}
}

class Program
{
    public static void Main()
    {
        Example e1 = new Example(1, 1);
//      e.Data2 = 10;	// error
//		e.Data4 = 10;	// error

    }
}
