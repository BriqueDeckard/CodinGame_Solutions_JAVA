package com.bd.notes.domain.repository.user;

import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.bd.notes.domain.aggregates.user.User;

/**
 * Manage User persistence
 * 
 * @author pierr
 *
 */
@Repository
public interface UserRepository extends JpaRepository<User, Long> {
	/**
	 * Find an user by its user name
	 * 
	 * @param username
	 * @return
	 */
	Optional<User> findByUsername(String username);

	/**
	 * Indicates whether an user exist with that username.
	 * 
	 * @param username
	 * @return
	 */
	Boolean existsByUsername(String username);

	/**
	 * Indicates whether an user exist with that email
	 * 
	 * @param email
	 * @return
	 */
	Boolean existsByEmail(String email);

}
