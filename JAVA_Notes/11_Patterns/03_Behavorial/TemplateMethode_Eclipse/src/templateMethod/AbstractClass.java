package templateMethod;

public abstract class AbstractClass {
	public final void generalMethod() {
		firstMethod();
		abstractMethod();
		
	}
	
	abstract void abstractMethod();
	
	void firstMethod()
	{
		System.out.print("\n First \n");
	}
	

}
