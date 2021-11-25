package com.bd.notes.infrastructure.security.jwt;

import java.util.Date;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.security.core.Authentication;
import org.springframework.stereotype.Component;

import com.bd.notes.infrastructure.security.services.userDetails.impl.UserDetailsImpl;

import io.jsonwebtoken.ExpiredJwtException;
import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.MalformedJwtException;
import io.jsonwebtoken.SignatureAlgorithm;
import io.jsonwebtoken.SignatureException;
import io.jsonwebtoken.UnsupportedJwtException;

@Component
public class JwtUtils {
	private static final Logger logger = LoggerFactory.getLogger(JwtUtils.class);

	@Value("${com.bd.notes.jwtSecret}")
	private String jwtSecret;

	@Value("${com.bd.notes.jwtExpirationMs}")
	private Long jwtExpirationMs;

	/**
	 * 
	 * @param authentication
	 * @return
	 */
	public String generateJwtToken(Authentication authentication) {
		return generateJwtTokenFromAuthent(authentication);
	}

	public boolean validateJwtToken(String authToken) {
		try {
			// Try to parse the token
			Jwts.parser().setSigningKey(jwtSecret).parseClaimsJws(authToken);
			return true;
		} catch (SignatureException e) {
			// Exception indicating that either calculating a signature or verifying an
			// existing signature of a JWT failed
			logger.error("Invalid JWT signature: {}", e.getMessage());
		} catch (MalformedJwtException e) {
			// Exception indicating that a JWT was not correctly constructed and should be
			// rejected.
			logger.error("Invalid JWT token: {}", e.getMessage());
		} catch (ExpiredJwtException e) {
			// Exception indicating that a JWT was accepted after it expired and must be
			// rejected.
			logger.error("JWT token is expired: {}", e.getMessage());
		} catch (UnsupportedJwtException e) {
			// Exception thrown when receiving a JWT in a particular format/configuration
			// that does not match the format expectedby the application.
			logger.error("JWT token is unsupported: {}", e.getMessage());
		} catch (IllegalArgumentException e) {
			// Thrown to indicate that a method has been passed an illegal orinappropriate
			// argument.
			logger.error("JWT claims string is empty: {}", e.getMessage());
		}

		return false;
	}

	public String generateJwtToken(UserDetailsImpl userPrincipal) {
		return generateTokenFromUsername(userPrincipal.getUsername());
	}

	public String generateTokenFromUsername(String username) {
		return Jwts //
				.builder() //
				.setSubject(username) //
				.setIssuedAt(new Date()) //
				.setExpiration(new Date((new Date()).getTime() + jwtExpirationMs)) //
				.signWith(SignatureAlgorithm.HS512, jwtSecret) //
				.compact();
	}

// --- Ancienne version : Avant le refresh ---
	private String generateJwtTokenFromAuthent(Authentication authentication) {
		UserDetailsImpl userPrincipal = (UserDetailsImpl) authentication.getPrincipal();

		return Jwts.builder() // JwtBuilder builds compact jwt strings
				.setSubject((userPrincipal.getUsername())) // Set the claims
				.setIssuedAt(new Date()) // identifies the time at which the JWT was issued
				.setExpiration(new Date((new Date()).getTime() + jwtExpirationMs)) // Set jwt claims expiration value
				.signWith(SignatureAlgorithm.HS512, jwtSecret) // Sign the JWT
				.compact(); // Build JWT
	}
// --- ---- ---

	public String getUserNameFromJwtToken(String token) {
		return Jwts // Factory to create instance of JWT
				.parser() // Used to parse JWT string
				.setSigningKey(jwtSecret) // set the signing key to verify JWT signature
				.parseClaimsJws(token) // parse and return the claims
				.getBody() // return a claims instance
				.getSubject(); // return the value
	}

}
