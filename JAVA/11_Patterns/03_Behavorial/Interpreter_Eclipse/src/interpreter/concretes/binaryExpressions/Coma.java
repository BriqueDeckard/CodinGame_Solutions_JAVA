package interpreter.concretes.binaryExpressions;

import contracts.abstractExpression.ABinaryExpression;
import contracts.interfacesExpression.IAbstractExpression;

/** Concrete binary expression
 * @author pierre.antoine
 *
 */
public class Coma extends ABinaryExpression {

	/** Constructor
	 * @param exp1
	 * @param exp2
	 */
	public Coma(IAbstractExpression exp1, IAbstractExpression exp2) {
		super(exp1, exp2);
		// TODO Auto-generated constructor stub
	}

	/* Specialized interpret method
	 * (non-Javadoc)
	 * @see contracts.interfacesExpression.IAbstractExpression#interpret()
	 */
	@Override
	public String interpret() {
		// TODO Auto-generated method stub
		return exp1.interpret() + "," + exp2.interpret();
	}

}
