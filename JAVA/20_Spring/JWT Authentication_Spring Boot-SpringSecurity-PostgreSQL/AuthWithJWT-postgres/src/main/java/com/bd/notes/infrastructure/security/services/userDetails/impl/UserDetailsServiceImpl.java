package com.bd.notes.infrastructure.security.services.userDetails.impl;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import com.bd.notes.domain.aggregates.user.User;
import com.bd.notes.domain.repository.user.UserRepository;

/**
 * @author pierr
 *
 */
@Service
public class UserDetailsServiceImpl implements UserDetailsService {

	@Autowired
	UserRepository userRepository;

	/**
	 *
	 * Thrown if an UserDetailsService implementation cannot locate a User byits
	 * username.
	 */
	@Override
	@Transactional
	public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
		User user = userRepository.findByUsername(username)
				.orElseThrow(() -> new UsernameNotFoundException("User not found with username: " + username));
		return UserDetailsImpl.build(user);
	}

}
