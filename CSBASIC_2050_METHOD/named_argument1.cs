class Program
{
    public static void SetRect(int x,     int y, 
							   int width, int height) {}

    public static void Main()
    {
		// positional arguments
        SetRect(10, 10, 30, 30);

		// named arguments
		SetRect(x:10, y:20, width:30, height:30);	

		SetRect(width:30, height:30, x:10, y:20);	

		// positional argument & named argument
		SetRect(10, 20, width:30, height:30);

		SetRect(10, y:20, 30, height:30);
		SetRect(10, 20, height:30, width:30);	


//		SetRect(y:10, x:20, 30, height: 30); // error  

//		SetRect(y:10, x:20, width:30, 30);   // error 						
 						
    }
}
