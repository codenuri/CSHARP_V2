class Example
{
	public int Data1
	{
		get => 0;
	}
    public int this[int idx]    		  
	{ 
		get => 0; 
	}
    public int this[string idx] 		  { get => 0; }
    public int this[int idx, int idx2]    { get => 0; }
    public int this[int idx, string idx2] { get => 0; }
}
class Program
{
    public static void Main()
    {
        Example e = new Example();

        int n1 = e[0];
        int n2 = e["A"];
        int n3 = e[0, 1];
        int n4 = e[0, "A"];
    }
}