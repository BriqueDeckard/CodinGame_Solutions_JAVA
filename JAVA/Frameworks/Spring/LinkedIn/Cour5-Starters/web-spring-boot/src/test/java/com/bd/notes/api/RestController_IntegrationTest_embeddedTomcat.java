package com.bd.notes.api;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.context.SpringBootTest.WebEnvironment;
import org.springframework.boot.test.web.client.TestRestTemplate;
import org.springframework.boot.web.server.LocalServerPort;

@SpringBootTest(webEnvironment = WebEnvironment.RANDOM_PORT) // choisit un port au hasard pour le serveur
public class RestController_IntegrationTest_embeddedTomcat {

	private static String expected;

	@BeforeAll
	private static void initialize() {
		expected = "42";
	}

	@LocalServerPort // injection du port choisit au hasard
	private int port;

	@Autowired
	private TestRestTemplate restTemplate; // Bean pour envoyer des requêtes au serveur

	@Test
	void domainOperation_returns42() {
		String actual = this.restTemplate.getForObject("http://localhost:" + port + "/test/domain", String.class);
		assertEquals(expected, actual);
	}

}
