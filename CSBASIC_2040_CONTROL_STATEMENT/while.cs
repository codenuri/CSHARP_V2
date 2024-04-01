using System;

int cnt = 0;

while( cnt < 10 )
{
	Console.Write($"{cnt}, ");
	++cnt;
}
Console.WriteLine();

cnt = 0;

while( true )
{
	Console.Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;
}

while( cnt ) {}
