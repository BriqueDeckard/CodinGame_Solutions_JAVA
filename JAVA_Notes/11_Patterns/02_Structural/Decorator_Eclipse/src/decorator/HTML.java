package decorator;

public class HTML {
public static void main(String[] args){
        
        String theString = "Un texte dans une page HTML";

        TextI t1 = new Texte(theString);
        
        System.out.println("=== pas de décoration ===");
        System.out.println(t1.toHTML());
        
        TextI t2 = new I(new Texte(theString));
        System.out.println("\n=== décoration avec I ===");
        System.out.println(t2.toHTML());
        
        TextI t3 = new B(new I(new Texte(theString)));
        System.out.println("\n=== décoration avec I et B ===");
        System.out.println(t3.toHTML());
        
        TextI t4 = new U(new I(new Texte(theString)));
        System.out.println("\n=== décoration avec I et U ===");
        System.out.println(t4.toHTML());
        
        TextI test = new Texte("BLABLABLA");
        TextI test2 = new I(test);
        TextI test3 = new U(test2);
        TextI test4 = new B(test3);
        
        System.out.println(test4.toHTML());

}
}