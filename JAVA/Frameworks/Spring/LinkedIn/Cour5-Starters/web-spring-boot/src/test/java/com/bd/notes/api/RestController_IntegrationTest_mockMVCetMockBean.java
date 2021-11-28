package com.bd.notes.api;

import static org.mockito.Mockito.when;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.get;
import static org.springframework.test.web.servlet.result.MockMvcResultHandlers.print;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.jsonPath;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.AutoConfigureMockMvc;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.test.web.servlet.MockMvc;

import com.bd.notes.application.services.user.UserApplicationService;

@SpringBootTest
@AutoConfigureMockMvc
public class RestController_IntegrationTest_mockMVCetMockBean {

	@Autowired
	private MockMvc mockMvc;

	@MockBean
	private UserApplicationService service;

	@Test
	void domainOperation_returns42() throws Exception {
				when(service.someDomainOperation()).thenReturn("42"); // redéfinie le comportement

		this.mockMvc//
				.perform(get("/test/domain")) // réalise la requete sur la route "/test/domain"
				.andDo(print()) // ecrit le resultat dans le flux
				.andExpect(status().isOk()) // s'assure que le résultat est ok
				.andExpect(jsonPath("$").value("42")); // s'assure que le body du resultat est bien "42"
	}
}
