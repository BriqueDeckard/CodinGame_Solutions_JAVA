package iterator;

public class ReverseIterator implements IIterator {
	 
    /** L'aggrégat parcouru par cet itérateur **/
    private ArrayAggregate aa;
    
    /** Index courant de l'itération **/
    private int index;
    
    public ReverseIterator(ArrayAggregate aa){
        this.aa = aa;
        this.index = aa.data.length;
    }
    
    /** 
        Renvoie l'élément courant et avance la position de l'itération
    **/
    public Object next() {
        index--;
        return aa.data[index];
    }
    
    /** 
        Indique s'il reste des éléments à parcourir
    **/
    public boolean hasNext() {
        return index > 0;
    }

}
