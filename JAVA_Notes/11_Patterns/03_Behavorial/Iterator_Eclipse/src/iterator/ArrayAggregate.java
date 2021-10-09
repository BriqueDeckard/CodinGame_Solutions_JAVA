package iterator;

/**Aggregat
 * @author pierre.antoine
 *
 */
public class ArrayAggregate {
	
	   Object[] data;
	    
	    public ArrayAggregate(Object[] data){
	        this.data = data;
	    }
	    
	    public IIterator getNormalIterator() {
	        return new NormalIterator(this);
	    }
	    
	    public IIterator getReverseIterator() {
	        return new ReverseIterator(this);
	    }

}
