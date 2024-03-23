using System;
using System.Text;
using static System.Console;

//StringBuilder sb1 = "AB";	// error
StringBuilder sb1 = new StringBuilder("AB");
StringBuilder sb2 = sb1;

sb1[0] = 'X';

WriteLine($"{sb1} {sb2}"); // XB  XB 

//sb1 = "CD";  // error
sb1.Clear();
sb1.Append("CD");

WriteLine($"{sb1} {sb2}");  // CD   CD
WriteLine($"{object.ReferenceEquals(sb1, sb2)}");

sb2 = new StringBuilder("XY");

WriteLine($"{object.ReferenceEquals(sb1, sb2)}");