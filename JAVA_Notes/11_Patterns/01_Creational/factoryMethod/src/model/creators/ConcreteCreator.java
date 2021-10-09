package model.creators;

import model.products.Thing;

public class ConcreteCreator extends ACreator{
	
	@Override
	protected Thing makeThing()
	{
		Thing thing = super.makeThing();
		thing.name = thing.name + "_made_";
		return thing;
		
	}
	
	
	

}
