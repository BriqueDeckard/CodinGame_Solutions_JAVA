package chainOfResponsibility.request;

/**
 * @author pierre.antoine
 *
 */
public class Request implements IRequest{
	
	 private double amount;
	    public Request(double amount) { this.amount = amount; }
	    public double getAmount() { return this.amount; }
	    public void setAmount(double amount)  { this.amount = amount; }
}
