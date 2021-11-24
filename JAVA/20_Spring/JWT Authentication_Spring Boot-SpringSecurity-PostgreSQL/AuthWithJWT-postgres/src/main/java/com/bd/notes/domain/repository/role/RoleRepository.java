package com.bd.notes.domain.repository.role;

import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.bd.notes.domain.aggregates.role.Role;
import com.bd.notes.domain.aggregates.role.RoleEnum;

@Repository
public interface RoleRepository extends JpaRepository<Role, Integer> {

	/**
	 * Find a role by its name
	 */
	Optional<Role> findRoleByName(RoleEnum name);

}
