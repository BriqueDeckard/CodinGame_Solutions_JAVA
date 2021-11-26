package com.bd.notes.infrastructure.security.services.signup.impl;

import java.util.HashSet;
import java.util.Set;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import com.bd.notes.domain.aggregates.payload.request.signup.SignupRequestDTO;
import com.bd.notes.domain.aggregates.role.Role;
import com.bd.notes.domain.aggregates.role.RoleEnum;
import com.bd.notes.domain.aggregates.user.User;
import com.bd.notes.infrastructure.data.dao.RoleDao;
import com.bd.notes.infrastructure.data.dao.UserDao;
import com.bd.notes.infrastructure.security.exception.EmailExistsException;
import com.bd.notes.infrastructure.security.exception.UsernameExistsException;
import com.bd.notes.infrastructure.security.services.signup.SignupService;

@Service
public class SignupServiceImpl implements SignupService {

	@Autowired
	UserDao userRepository;

	@Autowired
	RoleDao roleRepository;

	@Autowired
	PasswordEncoder encoder;

	@Override
	public void saveUser(SignupRequestDTO dto) throws EmailExistsException, UsernameExistsException {
		checkDto(dto);
		User user = userFactory(dto);
		userRepository.save(user);
	}

	private void doesEmailExist(String email) throws EmailExistsException {
		if (isEmailExists(email)) {
			throw new EmailExistsException(email);
		}
	}

	private void doesUsernameExist(String username) throws UsernameExistsException {
		if (isUsernameExists(username)) {
			throw new UsernameExistsException(username);
		}
	}

	private void checkDto(SignupRequestDTO dto) throws EmailExistsException, UsernameExistsException {
		doesEmailExist(dto.getEmail());
		doesUsernameExist(dto.getUsername());
	}

	private boolean isEmailExists(String email) {
		return userRepository.existsByEmail(email);
	}

	private boolean isUsernameExists(String username) {
		return userRepository.existsByUsername(username);
	}

	private User userFactory(SignupRequestDTO dto) {
		// Create new user's account
		User user = new User( //
				dto.getUsername(), //
				dto.getEmail(), //
				encoder.encode(dto.getPassword()));

		// Get roles
		Set<Role> roles = rolesFactory(dto);
		// Set the roles
		user.setRoles(roles);
		return user;
	}

	private Set<Role> rolesFactory(SignupRequestDTO dto) {

		Set<String> strRoles = dto.getRole();
		Set<Role> roles = new HashSet<>();

		// If roles ares null, add UserRole
		if (strRoles == null) {
			Role userRole = roleRepository //
					.findRoleByName(RoleEnum.ROLE_USER) //
					.orElseThrow(() -> new RuntimeException("Error: Role is not found."));

			roles.add(userRole);
		} else {
			// Else, assign the right role
			strRoles.forEach(role -> {
				switch (role) {
				case "ADMIN":
					Role adminRole = adminRoleFactory();
					roles.add(adminRole);
					break;
				case "MOD":
					Role modRole = moderatorRoleFactory();
					roles.add(modRole);

					break;
				default:
					Role userRole = userRoleFactory();
					roles.add(userRole);
				}
			});
		}
		return roles;
	}

	private Role adminRoleFactory() {
		Role adminRole = roleRepository //
				.findRoleByName(RoleEnum.ROLE_ADMIN) //
				.orElseThrow(() -> new RuntimeException("Error : Role is not found"));
		return adminRole;
	}

	private Role userRoleFactory() {
		Role userRole = roleRepository //
				.findRoleByName(RoleEnum.ROLE_USER) //
				.orElseThrow(() -> new RuntimeException("Error: Role is not found."));
		return userRole;
	}

	private Role moderatorRoleFactory() {
		Role modRole = roleRepository //
				.findRoleByName(RoleEnum.ROLE_MODERATOR) //
				.orElseThrow(() -> new RuntimeException("Error: Role is not found."));
		return modRole;
	}
}
