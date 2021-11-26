package com.bd.notes;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class AuthWithJwtPostgresApplication {

	/**
	 * App entry point
	 * @param args
	 */
	public static void main(String[] args) {
		SpringApplication.run(AuthWithJwtPostgresApplication.class, args);
	}

}
