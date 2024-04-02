using static System.Console;

int[] array = {1, 2, 3};

Tuple<int, double, string> t1 = 
			new Tuple<int, double, string>(1, 3.4, "AA");

WriteLine($"{t1.Item1}"); // 1
WriteLine($"{t1.Item2}"); // 3.4
WriteLine($"{t1.Item3}"); // "AA"


