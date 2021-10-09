package Observer.observables;

import java.util.ArrayList;
import java.util.List;

import Observer.contracts.IObservable;
import Observer.contracts.IObserver;

/**Worker class -Observed-
 * @author pierre.antoine
 * That class will regularly update a type "T" value 
 * with a method.
 */
public class Worker implements IObservable<Integer> {
	
	/**Observer list
	 * 
	 */
	private List<IObserver<Integer>> observers = new ArrayList<>();
	

	
	/* Observer implementation that allows to add an observer to the object
	 *  (non-Javadoc)
	 * @see Observer.Observable#addObserver(Observer.Observer)
	 */
	@Override
	public void addObserver(IObserver<Integer> observer) {

		observers.add(observer);
	}

	/* Take the data and call "update" for each observer in the list
	 * (non-Javadoc)
	 * @see Observer.Observable#notifyObserver(java.lang.Object)
	 */
	@Override
	public void notifyObserver(Integer data) {
		for(IObserver<Integer> observer : observers) {
			observer.update(data);
		}
	}
	
	/** Work
	 * Do some work and notify observer each time it works
	 */
	public void work() {
		for (int i = 0; i < 10; i++) {
			notifyObserver(i);
		}
	}

}
