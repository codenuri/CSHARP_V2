using System;
using static System.Console;

class Train
{
    private static readonly DateTime startTime;

	public  static string FirstTrainStartTime()
		=> startTime.ToLongTimeString();

	public Train() { }
	static Train() { startTime = DateTime.Now;}
}

class Program 
{
	public static void Main()
	{
		Train t1 = new Train();
		WriteLine($"{Train.FirstTrainStartTime()}");

		Train t2 = new Train();
		WriteLine($"{Train.FirstTrainStartTime()}");
	}
}