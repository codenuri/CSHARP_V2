using static System.Console;

// 사용자 코드
class Button
{
	public delegate void ClickHandler(Button source);

	public event ClickHandler? Click = null;

	public void UserPressButton() {	Click?.Invoke(this); }
}

class Program
{
	public static void Main()
	{
		Button btn = new Button();

		btn.Click += M1;
		btn.Click += M2;
		btn.Click -= M1;
//		btn.Click  = M1; // error

		btn.UserPressButton();		
	}
	public static void M1(Button btn) => WriteLine("M1");
	public static void M2(Button btn) => WriteLine("M2");
}