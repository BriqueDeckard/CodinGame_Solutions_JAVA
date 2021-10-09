package command.cmd.contracts;

public abstract class ACommand {

	public void execute() {
		System.out.println(this.getClass().getSimpleName() + ".execute()");
	}
}
