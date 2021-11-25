package com.bd.notes.api.controllers.auth;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.bd.notes.domain.aggregates.payload.request.login.LoginRequestDTO;
import com.bd.notes.domain.aggregates.payload.request.signup.SignupRequestDTO;
import com.bd.notes.domain.aggregates.payload.response.message.MessageResponse;
import com.bd.notes.infrastructure.security.exception.EmailExistsException;
import com.bd.notes.infrastructure.security.exception.UsernameExistsException;
import com.bd.notes.infrastructure.security.jwt.JwtUtils;
import com.bd.notes.infrastructure.security.services.signin.SigninService;
import com.bd.notes.infrastructure.security.services.signup.SignupService;

/**
 * Controller that ensure the authentication
 * 
 * @author pierr
 *
 */
@CrossOrigin(origins = "*", maxAge = 3600)
@RestController
@RequestMapping("/api/auth")
public class AuthController_v1 {

	@Autowired
	AuthenticationManager authenticationManager;

	@Autowired
	SignupService signupService;

	@Autowired
	SigninService signinService;

	@Autowired
	JwtUtils jwtUtils;

	/**
	 * @param dto
	 * @return
	 */
	@PostMapping("/signup")
	public ResponseEntity<?> registerUser(@Valid @RequestBody SignupRequestDTO dto) {
		try {
			signupService.saveUser(dto);
		} catch (EmailExistsException | UsernameExistsException e) {
			if (e instanceof EmailExistsException) {
				return emailAlreadyInUseResponseFactory();
			} else if (e instanceof UsernameExistsException) {
				return usernameAlreadyTakenResponseFactory();
			}
		}

		return ResponseEntity.ok(new MessageResponse("User registered successfully"));

	}

	@PostMapping("/signin")
	public ResponseEntity<?> authenticateUser(@Valid @RequestBody LoginRequestDTO loginRequest) {
		return ResponseEntity.ok(signinService.authenticateUser(loginRequest));
	}

	private ResponseEntity<?> emailAlreadyInUseResponseFactory() {
		return ResponseEntity //
				.badRequest() //
				.body(new MessageResponse("Error: Email is already in use!"));
	}

	private ResponseEntity<?> usernameAlreadyTakenResponseFactory() {
		return ResponseEntity //
				.badRequest() //
				.body(new MessageResponse("Error: Username is already taken."));
	}

}
