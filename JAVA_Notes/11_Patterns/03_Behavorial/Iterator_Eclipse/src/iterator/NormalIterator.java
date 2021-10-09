package iterator;

public class NormalIterator implements IIterator{
	/** L'aggrégat parcouru par cet itérateur **/
    private ArrayAggregate aa;
    
    /** Index courant de l'itération **/
    private int index;
    
    /**Le constructeur prend un aggregat en parametre, c'est celui qu'on va 
     * parcourir.
     * @param aa
     */
    public NormalIterator(ArrayAggregate aa){
        this.aa = aa;
        this.index = -1;
    }
    
  
    public Object next() {
        index++;
        return aa.data[index];
    }
    
  
    public boolean hasNext() {
        return index < aa.data.length - 1;
    }

}
