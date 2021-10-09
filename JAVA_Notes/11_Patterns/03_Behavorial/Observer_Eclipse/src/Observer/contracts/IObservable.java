package Observer.contracts;

/** Observable interface
 * @author pierre.antoine
 * Implemented by objects that contains the data that will be 
 * regularly modified/updated
 * @param <T>
 */
public interface IObservable<T> {
	
	/**The observable object needs that method to be able to have observers
	 * @param observer
	 */
	public void addObserver(IObserver<T> observer);
	
	/** The observable object needs that method to be able to notify observers.
	 * @param data
	 */
	public void notifyObserver(T data);

}
