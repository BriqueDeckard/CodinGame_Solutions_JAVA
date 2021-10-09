package chainOfResponsibility.handlers;

public class ConcreteHandler_A extends AHandler{

	@Override
	public double getAllowable() { return BASE * 10; }
}
