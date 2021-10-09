package Composite;

public class Leaf extends Component{
	public Leaf(String name) {
		super("leaf_"+name);
		
	}
	@Override
	public void add(Component component)
	{
		
	}
	@Override
	public void remove(Component component)
	{
		
	}
	
	@Override
	public Component getChild(int i)
	{
		return null;
	}
	
	
}
