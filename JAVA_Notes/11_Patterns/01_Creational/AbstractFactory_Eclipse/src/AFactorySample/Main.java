package AFactorySample;

import AFactorySample.Concretes.ProductAFactory;
import AFactorySample.Concretes.ProductBFactory;
import AFactorySample.Contracts.AFactory;
import AFactorySample.Contracts.AProduct;
import AFactorySample.Contracts.IProduct;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		AFactory factory;
		
		factory= new ProductAFactory();
		IProduct productA = factory.CreateProduct();
		
		factory = new ProductBFactory();
		IProduct productB = factory.CreateProduct();
		
		System.out.println(productA.getName());
		System.out.println(productB.getName());
		
	}

}
