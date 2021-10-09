package interpreter.concretes.binaryExpressions;

import contracts.abstractExpression.ABinaryExpression;
import contracts.interfacesExpression.IAbstractExpression;

public class Dot extends ABinaryExpression {

	public Dot(IAbstractExpression exp1, IAbstractExpression exp2) {
		super(exp1, exp2);
		// TODO Auto-generated constructor stub
	}

	@Override
	public String interpret() {
		// TODO Auto-generated method stub
		return exp1.interpret() + " ... " + exp2.interpret();
	}

}
