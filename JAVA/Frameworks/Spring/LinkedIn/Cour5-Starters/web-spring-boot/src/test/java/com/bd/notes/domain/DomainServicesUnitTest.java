package com.bd.notes.domain;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;

import com.bd.notes.domain.service.UserDomainService;
import com.bd.notes.domain.service.impl.UserDomainServiceImpl;

class DomainServicesUnitTest {

	private static UserDomainService domainServices;

	@BeforeAll
	private static void initialize() {
		domainServices = new UserDomainServiceImpl();
	}

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
