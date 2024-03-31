using static System.Console;

// C# 컴파일러가 변경한 코드
class Button
{
	public delegate void ClickHandler(Button source);
	
	private ClickHandler? Click = null;
	public void add_Click(   ClickHandler value) { Click += value; }
	public void remove_Click(ClickHandler value) { Click -= value; }
	
	public void UserPressButton() {	Click?.Invoke(this); }
}

class Program
{
	public static void Main()
	{
		Button btn = new Button();

		btn.add_Click(M1);
		btn.add_Click(M2);
		btn.remove_Click(M1);

		btn.UserPressButton();		
	}
	public static void M1(Button btn) => WriteLine("M1");
	public static void M2(Button btn) => WriteLine("M2");
}