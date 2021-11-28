package com.bd.notes.infrastructure.data.repository;

import java.util.Collection;

import org.springframework.data.repository.CrudRepository;

import com.bd.notes.infrastructure.data.entity.UserEntity;

public interface UserRepository extends CrudRepository<UserEntity, Long> {

	public Collection<UserEntity> findByLastName(String lastName);

}
