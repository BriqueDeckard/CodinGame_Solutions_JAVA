package command.cmd.concretes;

import command.cmd.contracts.ICommand;
import command.receivers.TextFile;

/** Concrete command that implements ICommand interface.
 * @author pierre.antoine
 *
 */
public class ConcreteCommand_C implements ICommand{

	private TextFile textFile;
	public ConcreteCommand_C(TextFile textFile) {
		System.out.println(this.getClass().getSimpleName() + " instantiated");
		this.textFile = textFile;
	}
	
	/* Concrete action.
	 * (non-Javadoc)
	 * @see command.cmd.contracts.ICommand#execute()
	 */
	@Override
	public String execute() {
		// TODO Auto-generated method stub
		System.out.println(this.getClass().getSimpleName() + ".execute");
		return this.textFile.open();
		
	}

}
