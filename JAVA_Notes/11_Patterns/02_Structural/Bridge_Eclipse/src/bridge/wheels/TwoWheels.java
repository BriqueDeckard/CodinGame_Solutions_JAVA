package bridge.wheels;

public class TwoWheels implements IWheel {

	@Override
	public int getWheelNb() {
		// TODO Auto-generated method stub
		return 2;
	}
	
	@Override
	public void display() {
		// TODO Auto-generated method stub
		System.out.println(getWheelNb());
	}

}
