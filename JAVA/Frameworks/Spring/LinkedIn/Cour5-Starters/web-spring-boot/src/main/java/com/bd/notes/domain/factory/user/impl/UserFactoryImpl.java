package com.bd.notes.domain.factory.user.impl;

import org.springframework.stereotype.Service;

import com.bd.notes.application.contracts.UserDTO;
import com.bd.notes.domain.aggregates.user.User;
import com.bd.notes.domain.aggregates.user.impl.UserImpl;
import com.bd.notes.domain.factory.user.UserFactory;

@Service
public class UserFactoryImpl implements UserFactory {

	@Override
	public User createUser(UserDTO dto) {
		return new UserImpl(//
				dto.getFirstName(), //
				dto.getLastName(), //
				dto.getId() //
		);
	}

	@Override
	public UserDTO createDTO(User entity) {
		return new UserDTO( //
				entity.getFirstName(), //
				entity.getLastName(), //
				entity.getId()//
		);
	}

}
