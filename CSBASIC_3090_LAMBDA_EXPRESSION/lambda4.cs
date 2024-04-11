using System;

// int Square(int n) { return n * n; }

Func<int, int> f1 = (int n) => { return n * n; };
Func<int, int> f2 = (int n) => n * n; 

Func<int, int> f3 = (n) => n * n; 
var            f4 = (int n) => n * n; 

Func<int, int> f5 = n => n * n; 

var f6 = object (bool b) => b ? 1 : "one";

