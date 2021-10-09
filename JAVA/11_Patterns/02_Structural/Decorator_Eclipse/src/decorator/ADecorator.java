package decorator;

public abstract class ADecorator implements TextI {
	public TextI Component;
	
	public ADecorator(TextI component)
	{
		this.Component = component;
	}

}
