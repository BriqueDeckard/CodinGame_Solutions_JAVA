package interpreter.concretes.terminalExpression;

import contracts.interfacesExpression.IAbstractExpression;

/** Concrete element
 * @author pierre.antoine
 *
 */
public class Word implements IAbstractExpression {

	public Word(String val)
	{
		this.word = val;
	}
	
	String word;
	@Override
	public String interpret() {
		// TODO Auto-generated method stub
		return word;
	}

}
