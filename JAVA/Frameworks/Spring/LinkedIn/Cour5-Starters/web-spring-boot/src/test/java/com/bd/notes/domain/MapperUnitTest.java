package com.bd.notes.domain;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotNull;

import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import com.bd.notes.application.services.user.mapper.UserMapper;
import com.bd.notes.application.services.user.mapper.impl.UserMapperImpl;
import com.bd.notes.domain.aggregates.user.User;
import com.bd.notes.domain.aggregates.user.impl.UserImpl;
import com.bd.notes.infrastructure.data.entity.UserEntity;

public class MapperUnitTest {

	private static UserMapper userMapper;

	private static UserEntity databaseEntity;

	private static User domainEntity;

	@BeforeEach
	private void clean() {

	}

	@BeforeAll
	private static void initialize() {
		userMapper = new UserMapperImpl();
		databaseEntity = new UserEntity(0, "firstName", "lastName");
		domainEntity = new UserImpl("firstName", "lastName", 0l);

	}

	@Test
	void test_mapDatabaseEntityToDomainEntity_expectedNewUser() {
		// -- Arrange
		User expected = domainEntity;
		// -- Act
		User actual = userMapper.mapDatabaseEntityToDomainEntity(databaseEntity);
		// -- Assert
		assertNotNull(actual);
		assertEquals(expected.getFirstName(), actual.getFirstName());
		assertEquals(expected.getLastName(), actual.getLastName());
		assertEquals(expected.getId(), actual.getId());

	}

	@Test
	void test_mapDomainEntityToDatabaseEntity() {
		// -- Arrange
		User expected = databaseEntity;
		// -- Act
		User actual = userMapper.mapDomainEntityToDatabaseEntity(domainEntity);
		// -- Assert
		assertNotNull(actual);
		assertEquals(expected.getFirstName(), actual.getFirstName());
		assertEquals(expected.getLastName(), actual.getLastName());
		assertEquals(expected.getId(), actual.getId());

	}

}
