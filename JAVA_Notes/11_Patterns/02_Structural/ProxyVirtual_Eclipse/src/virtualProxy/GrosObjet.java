package virtualProxy;

public class GrosObjet implements IGrosObjet{

    public GrosObjet(){
        System.out.println("    constructeur GrosObjet === Création très chère ===");
    }
    
    public void premièreMéthodeAyantVraimentBesoinDeGrosObjet(){
        System.out.println("    premièreMéthodeAyantVraimentBesoinDeGrosObjet()");
    }
    
    public void secondeMéthodeAyantVraimentBesoinDeGrosObjet(){
        System.out.println("    secondeMéthodeAyantVraimentBesoinDeGrosObjet()");
    }
    
}
