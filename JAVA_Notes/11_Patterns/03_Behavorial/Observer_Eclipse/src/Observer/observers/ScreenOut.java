package Observer.observers;

import Observer.contracts.IScreen;

/** Implements Screen, that implements Observer and specify the type. 
 *  The observer do some actions when it's notified.
 * @author pierre.antoine
 *
 */
public class ScreenOut implements IScreen{

	/* Interface implementation, the action called when the observer is notified. 
	 * (non-Javadoc)
	 * @see Observer.Screen#update(java.lang.Integer)
	 */
	@Override
	public void update(Integer data) {

		System.out.print(data);
	}

}
