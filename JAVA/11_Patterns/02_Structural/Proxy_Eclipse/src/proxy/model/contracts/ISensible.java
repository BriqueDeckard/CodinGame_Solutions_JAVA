package proxy.model.contracts;

public interface ISensible {

    public void rootMethod(String role);

    /** M�thode pouvant �tre ex�cut�e par ADMIN et ROOT, pas par USER **/
    public void adminMethod(String role);

    /** M�thode pouvant �tre ex�cut�e par tout le monde (USER, ADMIN, ROOT) **/
    public void userMethod(String role);

}
