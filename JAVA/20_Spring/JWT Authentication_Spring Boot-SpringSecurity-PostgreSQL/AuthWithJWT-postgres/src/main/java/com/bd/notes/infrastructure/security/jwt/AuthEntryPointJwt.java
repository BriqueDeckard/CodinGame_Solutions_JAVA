package com.bd.notes.infrastructure.security.jwt;

import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.MediaType;
import org.springframework.security.core.AuthenticationException;
import org.springframework.security.web.AuthenticationEntryPoint;
import org.springframework.security.web.access.ExceptionTranslationFilter;
import org.springframework.stereotype.Component;

import com.fasterxml.jackson.databind.ObjectMapper;

/**
 * Used by {@link ExceptionTranslationFilter} to commence an authentication
 * scheme.
 * 
 * @author pierr
 *
 */
@Component
public class AuthEntryPointJwt implements AuthenticationEntryPoint {
	private static final Logger logger = LoggerFactory.getLogger(AuthEntryPointJwt.class);

	/**
	 * This method will be triggerd anytime unauthenticated User requests a secured
	 * HTTP resource and an AuthenticationException is thrown.
	 *
	 * Commences an authentication scheme.
	 * <p>
	 * <code>ExceptionTranslationFilter</code> will populate the
	 * <code>HttpSession</code> attribute named
	 * <code>AbstractAuthenticationProcessingFilter.SPRING_SECURITY_SAVED_REQUEST_KEY</code>
	 * with the requested target URL before calling this method.
	 * <p>
	 * Implementations should modify the headers on the <code>ServletResponse</code>
	 * as necessary to commence the authentication process.
	 */
	@Override
	public void commence(HttpServletRequest request, HttpServletResponse response,
			AuthenticationException authException) throws IOException, ServletException {
		logger.error("Unauthorized error: {}", authException.getMessage());

		// Modify the response
		response = jsonResponseFactory(response);

		// Create the body
		final Map<String, Object> body = bodyFactory(authException, request);

		// write the value
		final ObjectMapper mapper = new ObjectMapper();
		mapper.writeValue(response.getOutputStream(), mapper);

		// HttpServletResponse.SC_UNAUTHORIZED is the 401 Status code. It indicates that
		// the request requires HTTP authentication.
		// response.sendError(HttpServletResponse.SC_UNAUTHORIZED, "Error:
		// Unauthorized");

	}

	private Map<String, Object> bodyFactory(AuthenticationException exception, HttpServletRequest request) {
		Map<String, Object> body = new HashMap<>();
		body.put("status", HttpServletResponse.SC_UNAUTHORIZED);
		body.put("error", "Unauthorized");
		body.put("message", exception.getMessage());
		body.put("path", request.getServletPath());

		return body;
	}

	private HttpServletResponse jsonResponseFactory(HttpServletResponse response) {
		if (response != null) {
			response.setContentType(MediaType.APPLICATION_JSON_VALUE);
			response.setStatus(HttpServletResponse.SC_UNAUTHORIZED);
		}
		return response;
	}

}
