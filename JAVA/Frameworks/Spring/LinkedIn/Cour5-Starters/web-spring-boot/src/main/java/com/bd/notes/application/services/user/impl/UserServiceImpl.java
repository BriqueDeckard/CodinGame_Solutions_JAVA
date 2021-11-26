package com.bd.notes.application.services.user.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.bd.notes.application.services.user.UserService;
import com.bd.notes.application.services.user.mapper.UserMapper;
import com.bd.notes.data.entity.UserEntity;
import com.bd.notes.data.repository.UserRepository;
import com.bd.notes.domain.aggregates.user.User;

@Service
public class UserServiceImpl implements UserService {

	@Autowired
	UserMapper mapper;

	private final UserRepository repository;

	public UserServiceImpl(UserRepository repository) {
		this.repository = repository;
	}

	@Override
	public List<User> getAllUsers() {
		return mapper.mapJpaEntitiesToDomainEnties(repository.findAll());
	}

	@Override
	public User findUserById(Long id) {
		UserEntity entity = repository.findById(id).orElse(null);
		return mapper.mapJpaEntityToDomainEntity(entity);
	}

	@Override
	public List<User> getUsersByLastName(String lastName) {
		return mapper.mapJpaEntitiesToDomainEnties(repository.findByLastName(lastName));
	}

	@Override
	public User addUser(User user) {		
		return mapper.mapJpaEntityToDomainEntity(repository.save(mapper.mapDomainEntityToJpaEntity(user)));
	}

	@Override
	public void deleteUser(Long id) {
		repository.deleteById(id);
	}

	@Override
	public void updateUser(User user) throws Exception {
		UserEntity oldEntity = repository.findById(user.getId()).orElse(null);
		if (oldEntity == null) {
			throw new Exception("User non trouvé");
		}
		oldEntity.setFirstName(user.getFirstName());
		oldEntity.setLastName(user.getLastName());

		this.repository.save(oldEntity);

	}

}
