package Composite;

public class Composite extends Component {

	public Composite(String name) {
		super("Composite_" +name);
		
	}

	@Override
	public void operation()
	{
		//!\ Important d'avoir "super.operation"
		super.operation();
		 
		for (Component component : children) {
			component.operation();
		}
	}
}
