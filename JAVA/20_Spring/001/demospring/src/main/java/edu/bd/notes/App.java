package edu.bd.notes;

import org.springframework.context.support.ClassPathXmlApplicationContext;

/**
 * Hello world!
 *
 */
public class App {
    public static void main(String[] args) {
        // starts Spring context
        new ClassPathXmlApplicationContext("applicationcontext.xml", App.class);
    }
}
