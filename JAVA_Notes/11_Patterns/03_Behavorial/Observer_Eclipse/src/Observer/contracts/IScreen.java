package Observer.contracts;

/** Interface that specify the data type
 * @author pierre.antoine
 *
 */
public interface IScreen extends IObserver<Integer>{
	public void update(Integer data);
	
	

}
