package command.invokers;

import java.util.ArrayList;
import java.util.List;

import command.cmd.contracts.ACommand;
import command.cmd.contracts.ICommand;

/**Command executor
 *  knows how to execute a given command but 
 *  doesn’t know how the command has been implemented
 * @author pierre.antoine
 *
 */
public class CommandExecutor {
	
	/**List of i commands.
	 * 
	 */
	private List<ICommand> iCommands = new ArrayList<ICommand>();
	
	/**List of a commands.
	 * 
	 */
	private List<ACommand> aCommands = new ArrayList<ACommand>();

	/** Execute ICommand.
	 * @param command
	 * @return
	 */
	public String executeCommands(ICommand command)
	{
		System.out.println(this.getClass().getSimpleName() + ".execute");
		iCommands.add(command);
		return command.execute();		
	}
	
	/**Execute ACommand.
	 * @param command
	 */
	public void executeCommands(ACommand command)
	{
		System.out.println(this.getClass().getSimpleName() + ".execute");
		aCommands.add(command);
		command.execute();
	}
	
	
}
