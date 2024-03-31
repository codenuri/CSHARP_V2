using static System.Console;

class Button
{
	public delegate void ClickHandler(Button source);
	public ClickHandler? Click = null;
	public void UserPressButton() 
	{
		Click?.Invoke(this); 
// 		if ( Click != null ) Click(this);		
	}
}
class Program
{
	public static void Main()
	{
		Button btn1 = new Button();
		Button btn2 = new Button();

		// 버튼을 누를때 호출될 메소드 등록
		btn1.Click = M1;
		btn2.Click = M2;

		btn1.UserPressButton();		
		btn2.UserPressButton();	
	}
	public static void M1(Button btn) => WriteLine("M1");
	public static void M2(Button btn) => WriteLine("M2");
}