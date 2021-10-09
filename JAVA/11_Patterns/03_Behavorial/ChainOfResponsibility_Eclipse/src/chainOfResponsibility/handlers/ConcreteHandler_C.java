package chainOfResponsibility.handlers;

public class ConcreteHandler_C extends AHandler{

	@Override
	public double getAllowable(){ return BASE * 40; }

}
