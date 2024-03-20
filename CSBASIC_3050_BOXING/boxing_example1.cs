using System;
using static System.Console;

struct Temperature : IComparable
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;

        if ( obj is Temperature other)
            return Value.CompareTo(other.Value);
        else
           throw new ArgumentException(
						"Object is not a Digit");      
    }
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(3.3);

        Console.WriteLine($"{t1.CompareTo(t2)}");
    }
}


