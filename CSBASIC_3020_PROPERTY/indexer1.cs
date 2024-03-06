using static System.Console;

class Sentence
{
    private string[] words;

    public Sentence(string s) 
	{ 
		words = s.Split(); 
	}	

    public string Text
    {
        get => string.Join(" ", words);
    }

    public string this[int idx]
    {
        get => words[idx];
		set => words[idx] = value;
    }			    
}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

		WriteLine( s[2] ); 	// Animal

        s[0] = "Cat";

        WriteLine(s.Text);	// Cat is Animal
    }
}
