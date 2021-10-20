package com.ecommerce.microcommerce;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import springfox.documentation.swagger2.annotations.EnableSwagger2;

/**
 * Entry point of the application. Created by Spring Boot
 */
// The annotation allows to define configurations, manage configuration automatically
// scann the packages to find Configuration beans.
// they can be replaced by @SpringBootApplication

@Configuration
@EnableAutoConfiguration
@ComponentScan
@EnableSwagger2
public class MicrocommerceApplication {

	public static void main(String[] args) {
		// Start the application. Creates the "application context".
		SpringApplication.run(MicrocommerceApplication.class, args);
	}

}
