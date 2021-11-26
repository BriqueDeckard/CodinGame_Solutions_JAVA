package com.bd.notes.application.services.user;

import java.util.List;

import com.bd.notes.domain.aggregates.user.User;

public interface UserService {

	List<User> getAllUsers();

	User findUserById(Long id);

	List<User> getUsersByLastName(String lastName);

	void addUser(User user);

	void deleteUser(Long id);

	void updateUser(User user) throws Exception;

}