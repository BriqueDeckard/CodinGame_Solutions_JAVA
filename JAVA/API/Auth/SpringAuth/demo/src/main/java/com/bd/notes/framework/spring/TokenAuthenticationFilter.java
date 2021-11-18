package com.bd.notes.framework.spring;

import java.io.IOException;

import javax.servlet.FilterChain;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.springframework.security.authentication.BadCredentialsException;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.AuthenticationException;
import org.springframework.security.web.authentication.AbstractAuthenticationProcessingFilter;
import org.springframework.security.web.util.matcher.RequestMatcher;

import static com.google.common.net.HttpHeaders.AUTHORIZATION;
import static java.util.Optional.ofNullable;
import static lombok.AccessLevel.PRIVATE;
import static org.apache.commons.lang3.StringUtils.removeStart;

import lombok.AccessLevel;
import lombok.experimental.FieldDefaults;

/**
 * The TokenAuthenticationFilter is responsible of extracting the authentication
 * token from the request headers. It takes the Authorization header value and
 * attempts to extract the token from it.
 * 
 * @author Emma
 *
 */
@FieldDefaults(level = AccessLevel.PRIVATE, makeFinal = true)
final class TokenAuthenticationFilter extends AbstractAuthenticationProcessingFilter {

	private static final String BEARER = "Bearer";

	public TokenAuthenticationFilter(final RequestMatcher requiresAuth) {
		super(requiresAuth);
	}

	@Override
	protected void successfulAuthentication(HttpServletRequest request, HttpServletResponse response, FilterChain chain,
			Authentication authResult) throws IOException, ServletException {
		// TODO Auto-generated method stub
		super.successfulAuthentication(request, response, chain, authResult);
		chain.doFilter(request, response);
	}

	@Override
	public Authentication attemptAuthentication(HttpServletRequest request, HttpServletResponse response)
			throws AuthenticationException, IOException, ServletException {

		final String param = ofNullable(request.getHeader(AUTHORIZATION)).orElse(request.getParameter("t"));
		final String token = ofNullable(param).map(value -> removeStart(value, BEARER)).map(String::trim)
				.orElseThrow(() -> new BadCredentialsException("Missing Authentication Token"));

		final Authentication auth = new UsernamePasswordAuthenticationToken(token, token);
		return getAuthenticationManager().authenticate(auth);
	}

}
