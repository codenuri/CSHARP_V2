using System;
using static System.Console;

string s1 = "AB";
string s2 = s1;

WriteLine($"{s2[0]}"); // 'A'

// s2[0] = 'X'; // error

WriteLine($"{object.ReferenceEquals(s1, s2)}");

s2 = "XY"; // new string("XY") 와 유사

WriteLine($"{object.ReferenceEquals(s1, s2)}");

WriteLine($"{s1} {s2}"); // "AB"  "XY"

