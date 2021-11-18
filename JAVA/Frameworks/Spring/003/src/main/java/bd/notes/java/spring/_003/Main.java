package bd.notes.java.spring._003;

import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Main {

    public static void main(String[] args) {
        // Ici on declare Contexte fondé sur une configuration définie préalablement.
        ApplicationContext context = new AnnotationConfigApplicationContext(ApplicationConfig.class);
    }
}
