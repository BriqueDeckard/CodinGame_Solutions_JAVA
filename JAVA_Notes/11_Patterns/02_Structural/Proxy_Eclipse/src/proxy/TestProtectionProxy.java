package proxy;

import java.util.Arrays;

import proxy.model.contracts.ISensible;
import proxy.model.sensible.Proxy;

public class TestProtectionProxy {

	public static void main(String[] args) {
		// Vérifie les paramètres
        String[] possibles = {"ROOT", "ADMIN", "USER"};
        String usage = "Utilisation : java TestProxy1 <rôle>\n<rôle> peut prendre les valeurs : ROOT, ADMIN, USER";

        
        if(args.length != 1){
            System.out.println(usage);
            System.out.println("il manque le paramètre rôle.");
            System.exit(0);
        }
        if(!Arrays.asList(possibles).contains(args[0])){
            System.out.println(usage);
            System.out.println("Valeur incorrecte : " + args[0]);
            System.exit(0);
        }
        
        String role = args[0];
      
       test("ROOT");
       test("ADMIN");
       test("USER");
        
	}
	
	public static void test (String role)
	{
		// You must instantiate Proxy, because Sensible is unreachable.
		 ISensible sensible = new Proxy();
         
	        sensible.rootMethod(role);
	        sensible.adminMethod(role);
	        sensible.userMethod(role);
	}

}
