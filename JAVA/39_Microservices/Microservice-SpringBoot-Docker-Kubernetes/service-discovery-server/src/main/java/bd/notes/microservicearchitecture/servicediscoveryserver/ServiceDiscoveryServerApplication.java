package bd.notes.microservicearchitecture.servicediscoveryserver;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.cloud.netflix.eureka.server.EnableEurekaServer;

// This application is an Eureka Server
// --> @EnableEurekaServer
/*
    Eureka Server is an application that holds the information about all
    client-service applications. Every Micro service will register into
    the Eureka server and Eureka server knows all the client applications
    running on each port and IP address. Eureka Server is also known
    as Discovery Server.
 */
@SpringBootApplication
@EnableEurekaServer
public class ServiceDiscoveryServerApplication {

    public static void main(String[] args) {
        SpringApplication.run(ServiceDiscoveryServerApplication.class, args);
    }

}
