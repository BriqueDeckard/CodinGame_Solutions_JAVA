package com.bd.notes.api;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.get;
import static org.springframework.test.web.servlet.result.MockMvcResultHandlers.print;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.jsonPath;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.AutoConfigureMockMvc;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.web.servlet.MockMvc;

@SpringBootTest
@AutoConfigureMockMvc
public class RestController_IntegrationTest_mockMVC {

	@Autowired
	private MockMvc mockMvc;

	@Test
	void domainOperation_returns42() throws Exception {
		this.mockMvc//
				.perform(get("/test/domain")) // réalise la requete sur la route "/test/domain"
				.andDo(print()) // ecrit le resultat dans le flux
				.andExpect(status().isOk()) // s'assure que le résultat est ok
				.andExpect(jsonPath("$").value("42")); // s'assure que le body du resultat est bien "42"
	}

}
