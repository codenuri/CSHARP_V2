using static System.Console;

class Button
{
	public void UserPressButton()
	{
		WriteLine("To Do Something"); 
	}
}

class Program
{
	public static void Main()
	{
		Button btn1 = new Button();
		Button btn2 = new Button();
	
		btn1.UserPressButton();		
		btn2.UserPressButton();		
	}
}