package Adapter.model;
//Ane adapter working with composition
public class SecondAneAdapter implements ICheval{

	private Ane ane = new Ane();
	@Override
	public void hennir() {
		// TODO Auto-generated method stub
		ane.braire();
	}

}
