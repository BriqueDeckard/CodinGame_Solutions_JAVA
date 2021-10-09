package AFactorySample.Concretes;

import AFactorySample.Contracts.AFactory;
import AFactorySample.Contracts.IProduct;

public class ProductBFactory extends AFactory{

	@Override
	public IProduct CreateProduct() {
		// TODO Auto-generated method stub
		return new ProductB();
	}

}
