package chainOfResponsibility;

import java.io.BufferedReader;
import java.io.InputStreamReader;

import chainOfResponsibility.handlers.AHandler;
import chainOfResponsibility.handlers.ConcreteHandler_A;
import chainOfResponsibility.handlers.ConcreteHandler_B;
import chainOfResponsibility.handlers.ConcreteHandler_C;
import chainOfResponsibility.handlers.ConcreteHandler_D;
import chainOfResponsibility.handlers.ConcreteHandler_E;
import chainOfResponsibility.request.Request;

public class Client {

	 public static void main(String[] args) {
	        
	        // create chain of responsability
	        AHandler handler_A = new ConcreteHandler_A();
	        AHandler handler_B = new ConcreteHandler_B();
	        AHandler handler_C = new ConcreteHandler_C();
	        AHandler handler_D = new ConcreteHandler_D();
	        AHandler handler_E = new ConcreteHandler_E();
	        
	        
	        handler_A.setSuccessor(handler_B);      
	        handler_B.setSuccessor(handler_C);
	        handler_C.setSuccessor(handler_D);
	        handler_D.setSuccessor(handler_E);
	     
	      

	        System.out.println("Purchase power limits :");
	        System.out.println("-----------------------");
	        System.out.println(handler_A.getRole() + " : " + handler_A.getAllowable());
	        System.out.println(handler_B.getRole() + " : " + handler_B.getAllowable());
	        System.out.println(handler_C.getRole() + " : " + handler_C.getAllowable());
	        System.out.println(handler_D.getRole() + " : " + handler_D.getAllowable());
	        System.out.println("-----------------------");
	        
	        System.out.println("\nPress Ctrl+C to end.");
	        
	        while (true) {
	            System.out.println("\nEnter the amount to check who should approve your expenditure.");
	            System.out.print("> ");
	            try {
	                double d = Double.parseDouble(new BufferedReader(new InputStreamReader(System.in)).readLine());
	                handler_A.HandleRequest(new Request(d));
	            }
	            catch (Exception e) {
	                System.out.println("Invalid amount.");
	            }
	        }
	    }
}
