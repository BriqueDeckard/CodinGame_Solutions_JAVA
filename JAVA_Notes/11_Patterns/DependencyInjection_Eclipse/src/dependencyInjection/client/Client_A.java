package dependencyInjection.client;

import dependencyInjection.Service_A.IService_A;

public class Client_A {

	IService_A service_A ; 
	
	public Client_A (IService_A service)
	{
		service_A = service;
	}
	
	public void action()
	{
		service_A.doSomething();
	}
}
