package com.bd.notes.domain;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import com.bd.notes.domain.service.UserDomainService;

@SpringBootTest
public class DomainServicesDITest {

	@Autowired
	private UserDomainService domainServices;

	@Test
	void test_domainOperation_expected42() {
		// Arrange
		String expected = "42";
		// Act
		String actual = domainServices.domainOperation();
		// Assert
		assertEquals(expected, actual);
	}

}
