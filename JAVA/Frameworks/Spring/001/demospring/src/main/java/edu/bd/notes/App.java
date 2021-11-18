package edu.bd.notes;

import org.springframework.context.support.ClassPathXmlApplicationContext;
import org.springframework.context.ApplicationContext;



/**
 * Hello world!
 *
 */
public class App {

    static private ApplicationContext context;
    public static void main(String[] args) {
        // starts Spring context
        context=  new ClassPathXmlApplicationContext("classpathxmlapplicationcontext-example.xml", App.class);
    }
}
