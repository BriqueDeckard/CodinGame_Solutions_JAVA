package com.bd.notes.application.services.user;

import java.util.List;

import com.bd.notes.application.contracts.dto.user.UserDTO;
import com.bd.notes.application.exceptions.EntityNotFoundException;

public interface UserApplicationService {

	List<UserDTO> getAllUsers();

	UserDTO findUserById(Long id) throws EntityNotFoundException;

	List<UserDTO> getUsersByLastName(String lastName);

	UserDTO addUser(UserDTO user);

	void deleteUser(Long id);

	void updateUser(UserDTO user) throws Exception;
	
	String someDomainOperation();

}