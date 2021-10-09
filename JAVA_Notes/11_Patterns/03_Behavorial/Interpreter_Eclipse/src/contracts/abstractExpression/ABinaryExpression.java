package contracts.abstractExpression;

import contracts.interfacesExpression.IAbstractExpression;

/**Abstract binary expression
 * @author pierre.antoine
 *
 */
public abstract class ABinaryExpression implements IAbstractExpression{
	
	/** Expression's elements
	 * 
	 */
	protected IAbstractExpression exp1, exp2;

	/** Constructor
	 * @param exp1
	 * @param exp2
	 */
	public ABinaryExpression(IAbstractExpression exp1, IAbstractExpression exp2)
	{
		this.exp1 = exp1;
		this.exp2 = exp2;
	}
}
