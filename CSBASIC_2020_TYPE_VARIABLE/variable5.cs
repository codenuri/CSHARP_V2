using static System.Console;

// casting
double d = 3.4;
//int n1 = d;		// error
int n2 = (int)d;	// ok


// nameof
int color = 100;
string s = "abcd";

WriteLine($"{nameof(color)} : {color}");
				// "color"  : 100

WriteLine($"{nameof(s.Length)} : {s.Length}");
				// "Length" : 4

