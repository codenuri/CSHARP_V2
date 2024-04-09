using static System.Console;

interface ICamera
{
	void Take();
}

class Camera : ICamera
{
	public void Take() => WriteLine("Take a picture");
}

class HDCamera : ICamera
{
	public void Take() => WriteLine("Take a HD picture");
}
class UHDCamera : ICamera
{
	public void Take() => WriteLine("Take a UHD picture");
}
class People 
{
	public void Use(ICamera c) => c.Take();
	
}

class Program 
{
	public static void Main()
	{
		People p = new People();
		Camera c = new Camera();
		p.Use(c);

		HDCamera hc = new HDCamera();
		p.Use(hc);		

		UHDCamera uhc = new UHDCamera();
		p.Use(uhc);	
	}
}
