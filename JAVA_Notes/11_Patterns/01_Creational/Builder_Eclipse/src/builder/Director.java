package builder;

public class Director 
{

	public void construct() {
		build_A();
		build_B();
	};
		
	public ABuilder builder;
	
	public void build_A()
	{
		builder = new FirstBuilder();
		builder.Build_A();
		builder.Build_B();
	}
	
	public void build_B()
	{
		builder = new SecondBuilder();
		builder.Build_A();
		builder.Build_B();
	}
	
}


