using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

foreach( int e in x )
{
	Write($"{e}, ");
}
WriteLine();

string s = "ABCDEFGHIJ";

foreach( char e in s )
{
	Write($"{e}, ");
}
