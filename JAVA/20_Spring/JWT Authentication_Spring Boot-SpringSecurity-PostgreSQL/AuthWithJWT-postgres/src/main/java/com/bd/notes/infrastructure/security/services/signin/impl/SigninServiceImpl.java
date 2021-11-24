package com.bd.notes.infrastructure.security.services.signin.impl;

import java.util.List;
import java.util.stream.Collectors;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.stereotype.Service;

import com.bd.notes.domain.aggregates.payload.request.login.LoginRequestDTO;
import com.bd.notes.domain.aggregates.payload.response.jwt.JwtResponse1;
import com.bd.notes.infrastructure.security.jwt.JwtUtils;
import com.bd.notes.infrastructure.security.services.signin.SigninService;
import com.bd.notes.infrastructure.security.services.userDetails.impl.UserDetailsImpl;

@Service
public class SigninServiceImpl implements SigninService {
	@Autowired
	AuthenticationManager authenticationManager;
	
	@Autowired
	JwtUtils jwtUtils;

	@Override
	public JwtResponse1 authenticateUser(LoginRequestDTO dto) {
		// Authenticate
		Authentication authentication = authenticationManager
				.authenticate(new UsernamePasswordAuthenticationToken(dto.getUsername(), dto.getPassword()));
		// Set authentication
		SecurityContextHolder.getContext().setAuthentication(authentication);

		// generate jwt
		String jwt = jwtUtils.generateJwtToken(authentication);
		
		UserDetailsImpl userDetails = (UserDetailsImpl) authentication.getPrincipal();

		List<String> roles = userDetails //
				.getAuthorities() //
				.stream() //
				.map(item -> item.getAuthority()).collect(Collectors.toList());
		
		return new JwtResponse1(jwt, userDetails.getId(), userDetails.getUsername(), userDetails.getEmail(), roles);
	}
}
