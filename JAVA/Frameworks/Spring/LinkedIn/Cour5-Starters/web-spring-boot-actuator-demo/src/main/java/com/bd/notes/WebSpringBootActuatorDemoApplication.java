package com.bd.notes;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.context.properties.EnableConfigurationProperties;

import com.bd.notes.configuration.ConfigProperties;

@SpringBootApplication
@EnableConfigurationProperties(ConfigProperties.class)
public class WebSpringBootActuatorDemoApplication {

	public static void main(String[] args) {
		SpringApplication.run(WebSpringBootActuatorDemoApplication.class, args);
	}

}
