package proxy.model.sensible;

import proxy.model.contracts.ISensible;

public class Proxy implements ISensible {
	
	private static Sensible _instance = new Sensible();
	
	  /** Méthode pouvant être exécutée par ROOT, pas par ADMIN ni USER **/
    public  void rootMethod(String role){
    	if(role.equalsIgnoreCase("ROOT"))
    	{
    		getInstance().rootMethod(role);
    	}
    	else
    	{
    		System.out.print("\nAcces denied.\n");
    	}
    	
        
    }
    
    /** Méthode pouvant être exécutée par ADMIN et ROOT, pas par USER **/
    public  void adminMethod(String role){
    	if((role.equalsIgnoreCase("ADMIN"))||(role.equals("ROOT")))
    	{
    		getInstance().adminMethod(role);
    	}
    	else
    	{
    		System.out.print("\nAcces denied.\n");
    	}
    }
    
    /** Méthode pouvant être exécutée par tout le monde (USER, ADMIN, ROOT) **/
    public  void userMethod(String role){
    	if((role.equalsIgnoreCase("USER"))||(role.equals("ROOT"))||(role.equals("ADMIN")))
    	{
    		getInstance().userMethod(role);
    		
    	}
    	else
    	{
    		System.out.print("\nAcces denied.\n");
    	}
    }
    
    private static Sensible getInstance()
    {
    	if(_instance == null )
    	{
    		_instance = new Sensible();
    	}
    	
    	return _instance;
    }

}
