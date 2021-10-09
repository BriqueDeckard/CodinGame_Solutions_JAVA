package chainOfResponsibility.handlers;

import chainOfResponsibility.request.Request;

/** Class to "join" the different handlers.
 * @author pierre.antoine
 *
 */
public abstract class AHandler {
	/**
	 * 
	 */
	protected static final double BASE = 100;
	/**To ensure that every handler have a successor.
	 * 
	 */
	public AHandler successor;

	/**To ensure that every handler have a getAllowable() method.
	 * @return
	 */
	public abstract double getAllowable();
	/**To ensure that every handler have a getRole() method.
	 * @return
	 */
	public String getRole() { return this.getClass().getSimpleName(); }
	
	/**Set the successor.
	 * @param successor
	 */
	public void setSuccessor(AHandler successor)
	{
		this.successor = successor;
	}
	
	/** Handle the request. If the request's amount is over the "getAllowable()" value,
	 * then the successor must handle the request.
	 * Every Concrete handler have a different getAllowable, so the "answer" will be 
	 * different for each handler.
	 * @param request
	 */
	public void HandleRequest(Request request)
	{
		if(request.getAmount() < this.getAllowable())
		{
			 System.out.println(this.getRole() + " will approve " + request.getAmount() + " $");
		}
		else if (successor != null)
		{
			 successor.HandleRequest(request);
		}
	};
}
