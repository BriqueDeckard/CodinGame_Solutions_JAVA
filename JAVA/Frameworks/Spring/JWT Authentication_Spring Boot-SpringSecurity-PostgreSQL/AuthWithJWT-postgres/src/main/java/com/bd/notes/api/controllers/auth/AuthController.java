package com.bd.notes.api.controllers.auth;

import java.util.List;
import java.util.stream.Collectors;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.bd.notes.domain.aggregates.payload.request.login.LoginRequestDTO;
import com.bd.notes.domain.aggregates.payload.request.signup.SignupRequestDTO;
import com.bd.notes.domain.aggregates.payload.request.tokenRefresh.TokenRefreshRequest;
import com.bd.notes.domain.aggregates.payload.response.jwt.JwtResponse2;
import com.bd.notes.domain.aggregates.payload.response.message.MessageResponse;
import com.bd.notes.domain.aggregates.payload.response.tokenRefresh.TokenRefreshResponse;
import com.bd.notes.domain.aggregates.token.RefreshToken;
import com.bd.notes.infrastructure.security.exception.EmailExistsException;
import com.bd.notes.infrastructure.security.exception.TokenRefreshException;
import com.bd.notes.infrastructure.security.exception.UsernameExistsException;
import com.bd.notes.infrastructure.security.jwt.JwtUtils;
import com.bd.notes.infrastructure.security.services.refreshToken.RefreshTokenService;
import com.bd.notes.infrastructure.security.services.signin.SigninService;
import com.bd.notes.infrastructure.security.services.signup.SignupService;
import com.bd.notes.infrastructure.security.services.userDetails.impl.UserDetailsImpl;

/**
 * Controller that ensure the authentication
 * 
 * @author pierr
 *
 */
@CrossOrigin(origins = "*", maxAge = 3600)
@RestController
@RequestMapping("/api/auth")
public class AuthController {

	@Autowired
	AuthenticationManager authenticationManager;

	@Autowired
	SignupService signupService;

	@Autowired
	SigninService signinService;

	@Autowired
	RefreshTokenService refreshTokenService;

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
		Authentication authentication = authenticationManager//
				.authenticate(new UsernamePasswordAuthenticationToken( //
						loginRequest.getUsername(), //
						loginRequest.getPassword()));

		SecurityContextHolder //
				.getContext() //
				.setAuthentication(authentication);

		UserDetailsImpl userDetails = (UserDetailsImpl) authentication.getPrincipal();

		String jwt = jwtUtils.generateJwtToken(userDetails);

		List<String> roles = userDetails //
				.getAuthorities() //
				.stream() //
				.map(item -> item.getAuthority()) //
				.collect(Collectors.toList());

		RefreshToken refreshToken = refreshTokenService.createRefreshToken(userDetails.getId());

		return ResponseEntity//
				.ok(new JwtResponse2(jwt, //
						refreshToken.getToken(), //
						userDetails.getId(), //
						userDetails.getUsername(), //
						userDetails.getEmail(), //
						roles));
	}

	@PostMapping("/refreshtoken")
	public ResponseEntity<?> refreshtoken(@Valid @RequestBody TokenRefreshRequest request) {
		String requestRefreshToken = request.getRefreshToken();

		return refreshTokenService//
				.findByToken(requestRefreshToken) // find the refresh token
				.map(refreshTokenService::verifyExpiration) // verify expiration
				.map(RefreshToken::getUser) // get the user 
				.map(user -> { 
					String token = jwtUtils.generateTokenFromUsername(user.getUsername()); // generate a new token
					return ResponseEntity.ok(new TokenRefreshResponse(token, requestRefreshToken)); // return the response entity
				})
				.orElseThrow(() -> new TokenRefreshException(requestRefreshToken, "Refresh token is not in database!"));
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
