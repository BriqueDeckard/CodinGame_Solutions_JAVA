package com.bd.notes.application;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotNull;

import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import com.bd.notes.application.contracts.dto.user.UserDTO;
import com.bd.notes.application.contracts.dto.user.UserRequest;
import com.bd.notes.application.contracts.dto.user.UserResponse;
import com.bd.notes.application.exceptions.EntityNotFoundException;
import com.bd.notes.application.services.user.UserApplicationService;

@SpringBootTest
public class UserApplicationServiceTest {

	private static UserDTO request;

	private static UserDTO response;

	@BeforeAll
	private static void initialize() {
		request = new UserRequest("firstName", "lastName", 0);
		response = new UserResponse("firstName", "lastName", 0);
	}

	@Autowired
	private UserApplicationService applicationServices;

	@Test
	void test_addUser_expectedInsertion() throws EntityNotFoundException {
		// -- Arrange
		UserDTO expected = response;
		// -- Act
		UserDTO actual1 = applicationServices.addUser(request);
		UserDTO actual2 = applicationServices.findUserById(actual1.getId());
		// -- Assert
		assertNotNull(actual1);
		assertEquals(expected.getFirstName(), actual1.getFirstName());
		assertEquals(expected.getLastName(), actual1.getLastName());
		
		assertNotNull(actual2);
		assertEquals(expected.getFirstName(), actual2.getFirstName());
		assertEquals(expected.getLastName(), actual2.getLastName());

	}

}
