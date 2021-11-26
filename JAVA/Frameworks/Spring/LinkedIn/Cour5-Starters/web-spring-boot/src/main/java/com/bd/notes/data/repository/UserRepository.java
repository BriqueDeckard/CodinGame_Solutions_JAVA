package com.bd.notes.data.repository;

import java.util.Collection;

import org.springframework.data.repository.CrudRepository;

import com.bd.notes.data.entity.UserEntity;

public interface UserRepository extends CrudRepository<UserEntity, Long> {

	public Collection<UserEntity> findByLastName(String lastName);

}
