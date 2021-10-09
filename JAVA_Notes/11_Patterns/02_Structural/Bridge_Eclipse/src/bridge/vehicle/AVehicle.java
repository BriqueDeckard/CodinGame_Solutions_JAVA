package bridge.vehicle;

import bridge.gear.IGear;
import bridge.wheels.IWheel;

public abstract class AVehicle implements IVehicle {

	public AVehicle(IGear gear, IWheel wheels)
	{
		this.gear = gear;
		this.wheels = wheels;
	}
	
	public void displayGear()
	{
		this.gear.display();
	}
	
	public void displayWheels()
	{
		this.wheels.display();
	}
	
	public IGear gear;
	
	public IWheel wheels;
}
