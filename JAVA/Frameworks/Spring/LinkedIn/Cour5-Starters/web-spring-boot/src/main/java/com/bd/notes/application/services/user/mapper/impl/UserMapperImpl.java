package com.bd.notes.application.services.user.mapper.impl;

import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.StreamSupport;

import org.springframework.stereotype.Service;

import com.bd.notes.application.services.user.mapper.UserMapper;
import com.bd.notes.data.entity.UserEntity;
import com.bd.notes.domain.aggregates.user.User;
import com.bd.notes.domain.aggregates.user.impl.UserImpl;

@Service
public class UserMapperImpl implements UserMapper {
	@Override
	public User mapDatabaseEntityToDomainEntity(UserEntity entity) {
		return new UserImpl(//
				entity.getFirstName(), //
				entity.getLastName(), //
				entity.getId() //
		);
	}

	@Override
	public List<User> mapDatabaseEntitiesToDomainEnties(Iterable<UserEntity> entities) {
		return StreamSupport //
				.stream(entities.spliterator(), false) //
				.map(user -> mapDatabaseEntityToDomainEntity(user)) //
				.collect(Collectors.toList());
	}

	@Override
	public UserEntity mapDomainEntityToDatabaseEntity(User user) {
		return new UserEntity( //
				user.getId(), //
				user.getFirstName(), //
				user.getLastName() //
		);
	}

	@Override
	public List<UserEntity> mapDomainEntitiesToJpaEntities(List<User> entities) {
		return entities //
				.stream() //
				.map(user -> mapDomainEntityToDatabaseEntity(user))//
				.collect(Collectors.toList());

	}
}
