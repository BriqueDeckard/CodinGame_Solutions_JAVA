package chainOfResponsibility.handlers;

public class ConcreteHandler_E extends AHandler{

	@Override
	public double getAllowable() { return Double.MAX_VALUE; }
}
