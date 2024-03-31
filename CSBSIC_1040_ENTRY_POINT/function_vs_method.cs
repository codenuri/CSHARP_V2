class Car
{
	private int speed = 0;
	private int color = 0;

	public void SetSpeed(int sp)
	{ 
		speed = sp;
	}
	
	public static void Main()
	{
		Car c = new Car();
		c.SetSpeed();
	}
}


