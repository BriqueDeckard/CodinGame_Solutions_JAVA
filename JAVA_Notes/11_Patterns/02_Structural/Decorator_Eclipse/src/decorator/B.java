package decorator;

public class B extends ADecorator{

	public B(TextI component) {
		super(component);
		// TODO Auto-generated constructor stub
	}

	@Override
	public String toHTML() {
		// TODO Auto-generated method stub
		return "<B>" + this.Component.toHTML() + "</B>";
	}

}
