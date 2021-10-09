package SingletonEclipse.model;

public class Test {
	
	private static Test _instance = null;
	
	private Test() {}
	
	private static Test getInstance() {
		if(_instance == null)
		{
			_instance = new Test();
		}
		return _instance;
	}
	
	public static void displayMessage()
	{
		getInstance().doDisplayMessage();
	}

	private  void doDisplayMessage()
	{
		System.out.println("Hello");
		
	}
}
