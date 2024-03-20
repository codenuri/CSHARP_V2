using System;
using static System.Console;

struct Temperature : IComparable< Temperature >
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    public int CompareTo(Temperature other)
    {
        return Value.CompareTo(other.Value);
    }
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(3.3);

        Console.WriteLine($"{t1.CompareTo(t2)}");

		object obj = t2;
		Console.WriteLine($"{t1.CompareTo(obj)}");
    }
}


