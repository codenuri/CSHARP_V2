using static System.Console;

// #1. Tuple 생성
Tuple<int, int, int> t1 = new Tuple<int, int, int>(1,2,3);
Tuple<int, int, int> t2 = Tuple.Create(1, 2, 3);
var t3 = new Tuple<int, int, int>(1,2,3);
var t4 = Tuple.Create(1, 2, 3);


// #2. tuple 요소 갯수 - 8개 까지 가능
//var t5 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8, 9); // error

// #3. Tuple 요소 접근
var t5 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);

//t5.Item1 = 10; // error. 요소 변경 안됨

WriteLine($"{t5.Item1}");		// 1
WriteLine($"{t5.Item2}");		// 2
WriteLine($"{t5.Item3}");		// 3
WriteLine($"{t5.Item4}");		// 4
WriteLine($"{t5.Item5}");		// 5
WriteLine($"{t5.Item6}");		// 6
WriteLine($"{t5.Item7}");		// 7
WriteLine($"{t5.Rest}");		// (8)
WriteLine($"{t5.Rest.Item1}");	// 8

// #4. nested tuple
var t6 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10));
WriteLine($"{t6.Rest.Item1}");
WriteLine($"{t6.Rest.Item1.Item1}"); // 8
WriteLine($"{t6.Rest.Item1.Item2}"); // 9