using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

var t1 = (a, b, c);


// #2. deconstruction
// int x, y, z;
// (x, y, z) = t1;

(int x, int y, int z) = t1;

WriteLine($"{x} {y} {z}"); // 1, 2, 3


// #3. 
(int a1, int a2, int a3) t2 = (1, 2, 3);
(int b1, int b2, int b3)    = (4, 5, 6);

int a1 = 0; // ok
//int b1 = 0; // error

WriteLine($"{t2.a1} {t2.a2} {t2.a3}");
WriteLine($"{b1} {b2} {b3}");
