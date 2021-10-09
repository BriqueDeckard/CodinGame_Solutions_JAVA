package AFactorySample.Contracts;

public abstract class AProduct implements IProduct {

	public String name = this.getClass().getSimpleName();
	
	@Override
	public String getName() {
		// TODO Auto-generated method stub
		return this.name;
	}
}
