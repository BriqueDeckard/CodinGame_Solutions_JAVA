package com.bd.notes.framework.spring;

import java.util.HashMap;
import java.util.Map;
import java.util.Objects;
import java.util.Optional;

import static java.util.Optional.ofNullable;

public class InMemoryUsers implements UserCrudService {

	Map<String, User> users = new HashMap<String, User>();

	@Override
	public User save(User user) {
		return users.put(user.getId(), user);
	}

	@Override
	public Optional<User> find(String id) {
		return ofNullable(users.get(id));
	}

	@Override
	public Optional<User> findByUsername(String userName) {
		return users.values().stream().filter(user -> Objects.equals(userName, user.getUsername())).findFirst();
	}

}
