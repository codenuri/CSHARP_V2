using static System.Console;

// 초기화되지 않은 변수는 쓰기만 가능.
int n;
int a = 0;

a = n;			// error
WriteLine(n);	// error 

n = a;	// ok
a = n;  // ok