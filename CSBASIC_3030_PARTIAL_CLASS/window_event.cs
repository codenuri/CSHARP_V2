using static System.Console;

partial class MainWindow 
{
	private int score = 0;

	public void Button_Click()
	{
		score += 10;
		WriteLine("button event handling");
	}
}