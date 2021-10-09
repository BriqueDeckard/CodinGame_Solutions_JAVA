package command.receivers;

/**Receiver - Executes the actual action when command's "execute" is called.
 * @author pierre.antoine
 *
 */
public class TextFile {
	
	public TextFile(String _name)
	{
		this.name = _name;
	}
	
	private String name;
	
	public String open()
	{
		System.out.println(this.getClass().getSimpleName() + ".open");
		return "Opening file "  + name;
	}

}
