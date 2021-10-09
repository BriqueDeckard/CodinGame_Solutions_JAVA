package dependencyInjection;

import dependencyInjection.Service_A.Service_A;
import dependencyInjection.Service_A.Sevice_B;
import dependencyInjection.client.Client_A;

public class Main {
	
	public static void main(String[] args)
	{
		Client_A client = new Client_A(new Service_A());
		client.action();
		
		client = new Client_A(new Sevice_B());
		client.action();
	}

	
	
}
