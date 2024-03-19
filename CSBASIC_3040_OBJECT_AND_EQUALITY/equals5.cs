using static System.Console;

class Program 
{
	public static void Check(string a, string b)
	{
		WriteLine($"a == b      : {a == b}");
		WriteLine($"a.Equals(b) : {a.Equals(b)}");
		WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(a, b)}");
	}
	public static void Main()
	{
		string s = "ABCD";
		string s1 = "ABCD";
		string s2 = new string("ABCD");
		string s3 = "ABCDEFG"[0..4];

		Check(s, s1); // 동일 객체
		Check(s, s2); // 다른 객체
		Check(s, s3); // 다른 객체
	}
}