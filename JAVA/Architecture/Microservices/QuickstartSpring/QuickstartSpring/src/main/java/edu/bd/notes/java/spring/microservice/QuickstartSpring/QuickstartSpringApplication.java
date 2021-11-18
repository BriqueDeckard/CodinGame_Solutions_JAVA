package edu.bd.notes.java.spring.microservice.QuickstartSpring;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@SpringBootApplication
// The @RestController annotation tells Spring that this code describes an endpoint
// that should be made available over the web.
// @SpringBootApplication is a convenience annotation that adds all of the following:
//
//@Configuration: Tags the class as a source of bean definitions for the application context.
//
//@EnableAutoConfiguration: Tells Spring Boot to start adding beans based on classpath settings, other beans,
// and various property settings. For example, if spring-webmvc is on the classpath, this annotation flags the
// application as a web application and activates key behaviors, such as setting up a DispatcherServlet.
//
//@ComponentScan: Tells Spring to look for other components, configurations, and services in the com/example
// package, letting it find the controllers.
@RestController
public class QuickstartSpringApplication {

    /**
     * The main() method uses Spring Boot’s SpringApplication.run() method to launch an application.
     *
     * @param args
     */
    public static void main(String[] args) {
        SpringApplication.run(QuickstartSpringApplication.class, args);
    }

    /**
     * The hello() method we’ve added is designed to take a String parameter called name, and
     * then combine this parameter with the word "Hello" in the code. This means that if you
     * set your name to “Amy” in the request, the response would be “Hello Amy”.
     *
     * @param name
     * @return
     */
    // The @GetMapping(“/hello”) tells Spring to use our hello() method to answer requests that
    // get sent to the http://localhost:8080/hello address.
    @GetMapping("/")
    // the @RequestParam is telling Spring to expect a name value in the request, but if it’s
    // not there, it will use the word “World” by default.
    public String hello(@RequestParam(value = "name", defaultValue = "World") String name) {
        return String.format("Hello %s", name);
    }

}
