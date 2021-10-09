package dependencyInjection.Service_A;

public class Sevice_B implements IService_A {

	@Override
	public void doSomething() {
		// TODO Auto-generated method stub
		System.out.println(this.getClass().getSimpleName() + " is doing something.");
	}

}
