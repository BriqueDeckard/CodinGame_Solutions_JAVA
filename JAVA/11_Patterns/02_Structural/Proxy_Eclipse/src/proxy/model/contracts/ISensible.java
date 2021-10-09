package proxy.model.contracts;

public interface ISensible {
	
    public  void rootMethod(String role);
    
    /** Méthode pouvant être exécutée par ADMIN et ROOT, pas par USER **/
    public  void adminMethod(String role);
    
    /** Méthode pouvant être exécutée par tout le monde (USER, ADMIN, ROOT) **/
    public  void userMethod(String role);


}
