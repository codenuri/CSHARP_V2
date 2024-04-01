using static System.Console;

int  n1 = 0;
int? n2 = n1;	// ok

//int? ni = null;
int? ni = 5;
//int  n3 = ni; // error

//int n5 = (int)ni;
//int n6 = ni.Value;
int n7 = ni.GetValueOrDefault();
int n8 = ni.GetValueOrDefault(3);

WriteLine($"{n7}, {n8}");



