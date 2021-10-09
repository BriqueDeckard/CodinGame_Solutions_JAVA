package model.creators;

import model.products.AProduct;
import model.products.Thing;

public abstract class ACreator {

	public AProduct factoryMethod() {
		Thing thing = makeThing();
		return thing;
	}
	
	protected Thing makeThing()
	{
		return new Thing();
	}
	
	
}
