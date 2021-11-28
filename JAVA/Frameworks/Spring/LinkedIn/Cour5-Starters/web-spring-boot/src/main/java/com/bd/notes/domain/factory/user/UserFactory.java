package com.bd.notes.domain.factory.user;

import com.bd.notes.application.contracts.dto.user.UserDTO;
import com.bd.notes.domain.aggregates.user.User;

public interface UserFactory {

	User createUser(UserDTO dto);

	UserDTO createDTO(User entity);

}