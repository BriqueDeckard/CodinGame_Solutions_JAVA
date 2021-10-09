package Observer;

import Observer.contracts.IScreen;
import Observer.observables.Worker;
import Observer.observers.ScreenErr;
import Observer.observers.ScreenOut;

public class Main {

	public static void main(String[] args) {

		//Observers initialization
		IScreen screenOut = new ScreenOut();
		IScreen screenErr = new ScreenErr();
		
		//observable initialization
		Worker worker = new Worker();
		//adds observers
		worker.addObserver(screenOut);
		worker.addObserver(screenErr);
		
		//Start
		worker.work();
	}

}
