package virtualProxy;

public class TestVirtualProxy{
    
    public static void main(String[] args) {
        
        //FirstWay();
        SecondWay();
    }
    
    public static void FirstWay()
    {
    	System.out.println("dans main() : avant instanciation de GrosObjet");
        GrosObjet go = new GrosObjet();
        System.out.println("dans main() : après instanciation de GrosObjet");
        
        System.out.println();
        System.out.println("dans main() : appel à go.méthodeAyantVraimentBesoinDeGrosObjet()");
        go.premièreMéthodeAyantVraimentBesoinDeGrosObjet();
        System.out.println("dans main() : appel à go.secondeMéthodeAyantVraimentBesoinDeGrosObjet()");
        go.secondeMéthodeAyantVraimentBesoinDeGrosObjet();
    }
    
    public static void SecondWay()
    {
    	 System.out.println("dans main() : avant instanciation de GrosObjetProxy");
         IGrosObjet go = new GrosObjetProxy();
         System.out.println("dans main() : après instanciation de GrosObjetProxy");
         
         System.out.println();
         System.out.println("dans main() : appel à go.méthodeAyantVraimentBesoinDeGrosObjet()");
         go.premièreMéthodeAyantVraimentBesoinDeGrosObjet();
         System.out.println("dans main() : appel à go.secondeMéthodeAyantVraimentBesoinDeGrosObjet()");
         go.secondeMéthodeAyantVraimentBesoinDeGrosObjet();
    	
    }
}
