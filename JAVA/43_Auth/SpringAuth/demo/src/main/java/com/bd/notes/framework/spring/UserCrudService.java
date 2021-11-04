package com.bd.notes.framework.spring;

import java.util.Optional;

public interface UserCrudService {
	User save(User user);
	
	Optional<User> find(String id);
	
	Optional<User> findByUsername(String userName);

}
