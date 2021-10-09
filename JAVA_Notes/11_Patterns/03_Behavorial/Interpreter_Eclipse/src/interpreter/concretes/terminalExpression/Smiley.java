package interpreter.concretes.terminalExpression;

import contracts.interfacesExpression.IAbstractExpression;

/** Concrete element of expression, implements IAbstractExpression
 * @author pierre.antoine
 *
 */
public class Smiley implements IAbstractExpression {

	/**The valued stocked into the expression
	 * 
	 */
	private String value;
	/**Constructor that instantiate the element and gives it its value 
	 * @param value
	 */
	public  Smiley(String value) {
		// TODO Auto-generated constructor stub
		switch(value) {
		case ":smile:" : this.value = " :) "; break;
		case ":fear:" : this.value = " :O " ; break ;
		default : this.value = " =_= " ; break;
		}
	}
	/* Return the value.
	 * (non-Javadoc)
	 * @see contracts.interfacesExpression.IAbstractExpression#interpret()
	 */
	@Override
	public String interpret() {
		// TODO Auto-generated method stub
		
		return this.value;
	}

}
