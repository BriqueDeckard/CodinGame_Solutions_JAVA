package com.bd.notes.application.services.user.impl;

import java.util.List;
import java.util.stream.Collectors;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.bd.notes.application.contracts.dto.user.UserDTO;
import com.bd.notes.application.exceptions.EntityNotFoundException;
import com.bd.notes.application.services.user.UserApplicationService;
import com.bd.notes.application.services.user.mapper.UserMapper;
import com.bd.notes.domain.aggregates.user.User;
import com.bd.notes.domain.factory.user.UserFactory;
import com.bd.notes.domain.service.UserDomainService;
import com.bd.notes.infrastructure.data.entity.UserEntity;
import com.bd.notes.infrastructure.data.repository.UserRepository;

@Service
public class UserApplicationServiceImpl implements UserApplicationService {

	@Autowired
	private UserMapper mapper;

	public UserApplicationServiceImpl(UserMapper mapper, UserRepository repository, UserFactory factory,
			UserDomainService domainService) {
		super();
		this.mapper = mapper;
		this.repository = repository;
		this.factory = factory;
		this.domainService = domainService;
	}

	@Autowired
	private UserRepository repository;

	@Autowired
	private UserFactory factory;

	@Autowired
	private UserDomainService domainService;

	@Override
	public List<UserDTO> getAllUsers() {
		return mapper.mapDatabaseEntitiesToDomainEnties(repository.findAll())//
				.stream() //
				.map(user -> factory.createDTO(user)) //
				.collect(Collectors.toList());
	}

	@Override
	public UserDTO findUserById(Long id) throws EntityNotFoundException {
		// Find the user
		UserEntity entity = repository.findById(id).orElse(null);
		// Check for null
		if (entity == null) {
			throw new EntityNotFoundException(id.toString());
		}
		// map
		User domainEntity = mapper.mapDatabaseEntityToDomainEntity(entity);
		// create DTO
		UserDTO dto = factory.createDTO(domainEntity);
		return dto;
	}

	@Override
	public List<UserDTO> getUsersByLastName(String lastName) {
		return mapper.mapDatabaseEntitiesToDomainEnties(repository.findByLastName(lastName))//
				.stream()//
				.map(user -> factory.createDTO(user))//
				.collect(Collectors.toList());
	}

	@Override
	public UserDTO addUser(UserDTO dto) {
		// Create user from dto
		User user = factory.createUser(dto);
		// Create entity from user
		UserEntity entity = mapper.mapDomainEntityToDatabaseEntity(user);
		// save entity
		entity = repository.save(entity);
		// create user from entity
		user = mapper.mapDatabaseEntityToDomainEntity(entity);
		// create dto from user
		dto = factory.createDTO(user);
		return dto;
	}

	@Override
	public void deleteUser(Long id) {
		repository.deleteById(id);
	}

	@Override
	public void updateUser(UserDTO dto) throws Exception {
		UserEntity oldEntity = repository.findById(dto.getId()).orElse(null);
		if (oldEntity == null) {
			throw new EntityNotFoundException(dto.toString());
		}
		oldEntity.setFirstName(dto.getFirstName());
		oldEntity.setLastName(dto.getLastName());

		this.repository.save(oldEntity);

	}

	@Override
	public String someDomainOperation() {
		return domainService.domainOperation();
	}

}
