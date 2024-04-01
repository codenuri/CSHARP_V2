using static System.Console;

//int? n1 = null;
int? n1 = 5;

// int n2 = n1; // error

int n3 = n1 ?? 3;

WriteLine($"{n3}"); // 3
					// 5


//int? n4 = null;
int? n4 = 5;

n4 ??= 10;

WriteLine($"{n4}");


