package decorator;

public class I  extends ADecorator{

	public I(TextI component) {
		super(component);
		// TODO Auto-generated constructor stub
	}

	@Override
	public String toHTML() {
		// TODO Auto-generated method stub
		return "<i>" + this.Component.toHTML() + "</I>";
	}
	
	

}
