package client;

import contracts.interfacesExpression.IAbstractExpression;
import interpreter.concretes.binaryExpressions.Coma;
import interpreter.concretes.binaryExpressions.Dot;
import interpreter.concretes.terminalExpression.Smiley;
import interpreter.concretes.terminalExpression.Word;

public class Client {

	public static void operation()
	{
		var smile = new Smiley(":smile:");
		var fear = new Smiley(":fear:");
		var coma = new Coma(smile, fear);
		var dot = new Dot(coma, coma);
		System.out.print(dot.interpret());		
	}
}
