package model;

import model.creators.ACreator;
import model.creators.ConcreteCreator;
import model.creators.SoConcreteCreator;
import model.products.AProduct;

public class Client {
	
	public void simulate()
	{
		ACreator creator_1 = new ConcreteCreator();
		
		AProduct thing_1 = creator_1.factoryMethod();
		System.out.println(thing_1.name);
		
		ACreator creator_2 = new SoConcreteCreator();
		
		AProduct thing_2 = creator_2.factoryMethod();
		System.out.println(thing_2.name);
	}

}
