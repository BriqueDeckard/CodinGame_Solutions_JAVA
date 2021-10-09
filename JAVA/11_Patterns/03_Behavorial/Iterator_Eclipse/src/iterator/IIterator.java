package iterator;

/**Interface qui garantis qu'on a bien un iterateur.
 * @author pierre.antoine
 *
 */
public interface IIterator {

	/** 
	 * Renvoie l'élément courant et avance la position de l'itération
	 **/ 
	public Object next();
	
	/** 
	 * Indique s'il reste des éléments à parcourir
	 **/
	public boolean hasNext();
}
