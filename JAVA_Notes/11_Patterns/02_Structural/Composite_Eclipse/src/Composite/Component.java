package Composite;

import java.util.ArrayList;
import java.util.List;



public class Component {
	public String name;

	public Component (String name)
	{
		this.name = "component_"+name;
	}
	public List<Component> children = new ArrayList<Component>();
	public void operation() {
		
		System.out.println(this.name);
		
	};
	public void add(Component component) {
		if(children == null)
		{
			children = new ArrayList<Component>();
		}
		children.add(component);
	};
	public void remove(Component component) {
		if(children.contains(component))
		{
			children.remove(component);
			
		}
	};
	public Component getChild(int i) {
		if(children.size() >= i)
		{
			return children.get(i);
		}
		return new Component("new");
		
	};
}
