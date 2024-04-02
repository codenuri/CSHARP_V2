using static System.Console;

// #1. ValueTuple 생성
ValueTuple<int, int, int> vt1 = new ValueTuple<int, int, int>(1, 2, 3);

ValueTuple<int, int, int> vt2 = ValueTuple.Create(1,2,3);

ValueTuple<int, int, int> vt3 = (1, 2, 3);
(int, int, int) vt4 = (1, 2, 3);
var vt5 = (1, 2, 3);

// #2. 주의
var a = (1);		// int a = 1
var b = (1, 2);		// (int, int) b = (1, 2)

// #3. 요소 접근
var vt6 = (1, 2, 3);
vt6.Item1 = 20;				// ok
WriteLine($"{vt6.Item1}");	// 20

// #4. Named Member
(int,     int,     int)       vt7 = (1,2,3); // unnamed
(int one, int too, int three) vt8 = (1,2,3); // named

var vt9 = (one:1, too:2, three:3 );

WriteLine($"{vt8.one}");
WriteLine($"{vt9.one}");
WriteLine($"{vt9.Item1}");


