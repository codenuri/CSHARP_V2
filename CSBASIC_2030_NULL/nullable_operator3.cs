
string s1 = "hello";

object o1 = s1;

//int n1 = o1;		// compile error	

//int n1 = (int)o1; 	// runtime error

if ( o1 is int )
{
	int n2 = (int)o1;
}

if ( o1 is int n3 )
{
}
//==========================

//int ret = o1 as int; // error
int? ret1 = o1 as int?; // ok
int  ret2 = (o1 as int?) ?? 0;