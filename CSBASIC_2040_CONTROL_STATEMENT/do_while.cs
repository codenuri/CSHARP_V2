using System;

int cnt = 0;

do
{
	Console.Write($"{cnt}, ");
	++cnt;
}
while( cnt < 10 );

Console.WriteLine();

cnt = 0;

do
{
	Console.Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;
} while( true );

