package decorator;

public class U extends ADecorator {

	public U(TextI component) {
		super(component);
		// TODO Auto-generated constructor stub
	}

	@Override
	public String toHTML() {
		// TODO Auto-generated method stub
		return "<U>" + this.Component.toHTML() + "</U>";
	}

}
