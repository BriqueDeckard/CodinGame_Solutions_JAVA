package bridge;

import java.util.ArrayList;

import bridge.gear.AutomaticGear;
import bridge.gear.ManualGear;
import bridge.vehicle.AVehicle;
import bridge.vehicle.Car;
import bridge.vehicle.Truck;
import bridge.wheels.FourWheels;
import bridge.wheels.TwoWheels;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		AVehicle vehicle_1 = new Car(new AutomaticGear(), new TwoWheels());
		AVehicle vehicle_2 = new Car(new ManualGear(), new FourWheels());
		AVehicle vehicle_3 = new Truck(new AutomaticGear(), new TwoWheels());
		AVehicle vehicle_4 = new Truck(new ManualGear(), new FourWheels());
		
		ArrayList<AVehicle> list = new ArrayList<AVehicle>();
		
		list.add(vehicle_1);
		list.add(vehicle_2);
		list.add(vehicle_3);
		list.add(vehicle_4);
		
		for (AVehicle aVehicle : list) {
			aVehicle.displayGear();
			aVehicle.displayWheels();
		}
		
	}

}
