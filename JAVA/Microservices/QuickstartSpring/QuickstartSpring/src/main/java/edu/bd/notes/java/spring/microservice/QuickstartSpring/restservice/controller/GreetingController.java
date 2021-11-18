package edu.bd.notes.java.spring.microservice.QuickstartSpring.restservice.controller;

import edu.bd.notes.java.spring.microservice.QuickstartSpring.restservice.model.Greeting;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.concurrent.atomic.AtomicLong;

/**
 * In Spring’s approach to building RESTful web services, HTTP requests are handled by a
 * controller. These components are identified by the @RestController annotation, and the
 * GreetingController shown in the following listing
 * (from src/main/java/com/example/restservice/GreetingController.java) handles GET
 * requests for /greeting by returning a new instance of the Greeting class:
 *
 * This code uses Spring @RestController annotation, which marks the class as a controller where every method
 * returns a domain object instead of a view. It is shorthand for including both @Controller and @ResponseBody.
 *
 * This code uses Spring @RestController annotation, which marks the class as a controller where every method
 * returns a domain object instead of a view. It is shorthand for including both @Controller and @ResponseBody.
 */
@RestController
public class GreetingController {

    private static final String template = "Hello, %s!";
    private final AtomicLong counter = new AtomicLong();

    // The @GetMapping annotation ensures that HTTP GET requests to /greeting are mapped to the greeting() method.
    // @RequestParam binds the value of the query string parameter name into the name parameter of the greeting()
    // method. If the name parameter is absent in the request, the defaultValue of World is used.
    @GetMapping("/greeting")
    public Greeting greeting(@RequestParam(value = "name", defaultValue = "World") String name) {
        // The Greeting object must be converted to JSON. Thanks to Spring’s HTTP message converter support,
        // you need not do this conversion manually. Because Jackson 2 is on the classpath,
        // Spring’s MappingJackson2HttpMessageConverter is automatically chosen to convert
        // the Greeting instance to JSON.
        return new Greeting(counter.incrementAndGet(), String.format(template, name));
    }
}
