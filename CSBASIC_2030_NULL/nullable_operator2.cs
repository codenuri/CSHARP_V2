using static System.Console;

class Car 
{
	public void Go() { WriteLine("Car Go");}
	public int  GetSpeed() { return 10; }
}

class Program
{	
	public static Car MakeCar(int speed) 
	{
		return speed < 100 ? new Car() : null;
	}

    public static void Main()
    {
//		Car c = MakeCar(50);
		Car c = MakeCar(150);

		c?.Go();			
//		if ( c != null ) { c.Go();}

//		int? ret = c?.GetSpeed();

		int ret = c?.GetSpeed() ?? 0;


		int[] x = null;
		int? n = x?[0];
    }      
}   

