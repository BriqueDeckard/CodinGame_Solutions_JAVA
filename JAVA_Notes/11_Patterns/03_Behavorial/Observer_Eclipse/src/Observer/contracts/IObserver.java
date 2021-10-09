package Observer.contracts;

/**Observer interface
 * @author pierre.antoine
 * Implemented by the object that will be notified when A object
 * will be modified. A object is the one that implements 
 * Obervable.
 * @param <T>
 */
public interface IObserver<T> {
	
	/**The object that needs to be notified must have the update method to "communicate" with the "observable" object
	 * @param data
	 */
	public void update(T data) ;
}
