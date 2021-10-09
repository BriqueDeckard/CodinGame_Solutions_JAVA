package command.client;

import java.util.ArrayList;
import java.util.List;

import command.cmd.concretes.ConcreteCommand_A;
import command.cmd.concretes.ConcreteCommand_B;
import command.cmd.concretes.ConcreteCommand_C;
import command.cmd.contracts.ACommand;
import command.cmd.contracts.ICommand;
import command.invokers.CommandExecutor;
import command.receivers.TextFile;

public class Client {

	/**Demo with the abstract command class.
	 * 
	 */
	public void aCommandDemo()
	{
		//Invoker - produce requests ;
		List<ACommand> queue = new ArrayList<ACommand>();
		queue.add(new ConcreteCommand_A());
		queue.add(new ConcreteCommand_B());
		
		
		//Receiver - execute requests.
		for(ACommand command : queue)
		{
			command.execute();
		}
	}
	
	/**Demo with the command interface.
	 * 
	 */
	public void iCommandDemo()
	{
		List<ICommand> queue = new ArrayList<ICommand>();
		TextFile textFile = new TextFile("textFile_1");
		ICommand concreteCommand = new ConcreteCommand_C(textFile);
		queue.add(concreteCommand);
		
		for(ICommand command : queue)
		{
			System.out.println(command.execute());
		}		
	}
	
	/**Demo with the executor.
	 * 
	 */
	public void executorDemo()
	{
	
		TextFile textFile = new TextFile("textFile_1");
		ICommand concreteICommand = new ConcreteCommand_C(textFile);
		CommandExecutor executor = new CommandExecutor();
		System.out.println(executor.executeCommands(concreteICommand));
		
		ACommand concreteACommand = new ConcreteCommand_A();
		executor.executeCommands(concreteACommand);
		
		
	}
}
