using static System.Console;

class Button
{
	public delegate void ClickHandler(Button source);
//	public ClickHandler? Click = null;
	public event ClickHandler? Click = null;
	public void UserPressButton() {	Click?.Invoke(this); }
}
class Program
{
	public static void Main()
	{
		Button btn = new Button();

//		btn.Click  = M1; // error
		btn.Click += M2; // ok. 
		btn.Click += M3;
//		btn.Click = M3;  // error

//		btn.Click?.Invoke(btn); // error

		btn.UserPressButton();		
	}
	public static void M1(Button btn) => WriteLine("M1");
	public static void M2(Button btn) => WriteLine("M2");
	public static void M3(Button btn) => WriteLine("M3");
}