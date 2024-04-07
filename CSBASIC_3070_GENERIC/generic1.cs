class Program
{
    public static void swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
    public static void swap(ref double a, ref double b)
    {
        double tmp = a;
        a = b;
        b = tmp;
    }	
    public static void Main()
    {
        int n1 = 10,  n2 = 20;
		swap(ref n1, ref n2);

		double d1 = 1.1, d2 = 2.3;
		swap(ref d1, ref d2);
    }
}