package model.creators;

import model.products.Thing;

public class SoConcreteCreator extends ACreator{
	@Override
	protected Thing makeThing()
	{
		Thing thing = super.makeThing();
		thing.name = thing.name + "_soooo_made_";
		return thing;
		
	}
}