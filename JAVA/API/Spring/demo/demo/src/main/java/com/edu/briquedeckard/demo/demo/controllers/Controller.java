package com.edu.briquedeckard.demo.demo.controllers;

//Imports, vscode should auto add these as needed
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

//This annotation tells Spring this is a RestAPI Controller
@RestController
public class Controller {

    // This tells spring this function is a route for a get request to "/"
    @RequestMapping(value = "/", method = RequestMethod.GET)
    public String Hello() {
        // The response will include the return value
        return "Hello World";
    }

}