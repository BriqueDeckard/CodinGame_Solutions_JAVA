package bridge.wheels;

public class FourWheels implements IWheel {

	@Override
	public int getWheelNb() {
		// TODO Auto-generated method stub
		return 4;
	}

	@Override
	public void display() {
		// TODO Auto-generated method stub
		System.out.println(getWheelNb());
	}

}
