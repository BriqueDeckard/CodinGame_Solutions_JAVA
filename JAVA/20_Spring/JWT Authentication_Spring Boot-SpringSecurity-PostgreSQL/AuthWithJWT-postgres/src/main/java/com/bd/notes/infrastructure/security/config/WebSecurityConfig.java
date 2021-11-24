package com.bd.notes.infrastructure.security.config;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.method.configuration.EnableGlobalMethodSecurity;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.builders.WebSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfigurerAdapter;
import org.springframework.security.config.http.SessionCreationPolicy;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.web.authentication.UsernamePasswordAuthenticationFilter;

import com.bd.notes.infrastructure.security.jwt.AuthEntryPointJwt;
import com.bd.notes.infrastructure.security.jwt.AuthTokenFilter;
import com.bd.notes.infrastructure.security.services.userDetails.impl.UserDetailsServiceImpl;

/**
 * @EnableWebSecurity allows Spring to find and automatically apply the class to
 *                    the global Web Security.
 * @EnableGlobalMethodSecurity provides AOP security on methods. It
 *                             enables @PreAuthorize, @PostAuthorize, it also
 *                             supports JSR-250.
 * 
 * @author pierr
 *
 */
@Configuration
@EnableWebSecurity
@EnableGlobalMethodSecurity(prePostEnabled = true)
public class WebSecurityConfig extends WebSecurityConfigurerAdapter {
	@Autowired
	UserDetailsServiceImpl userDetailsService;

	@Autowired
	private AuthEntryPointJwt unauthorizedHandler;

	@Bean
	public AuthTokenFilter authenticationJwtTokenFilter() {
		return new AuthTokenFilter();
	}

	@Override
	protected void configure(AuthenticationManagerBuilder authenticationManagerBuilder) throws Exception {
		authenticationManagerBuilder.userDetailsService(userDetailsService).passwordEncoder(passwordEncoder());
	}

	@Bean
	@Override
	public AuthenticationManager authenticationManagerBean() throws Exception {
		return super.authenticationManagerBean();
	}

	@Bean
	public PasswordEncoder passwordEncoder() {
		return new BCryptPasswordEncoder();
	}

	/**
	 * override the configure(HttpSecurity http) method from
	 * WebSecurityConfigurerAdapter interface. It tells Spring Security how we
	 * configure CORS and CSRF, when we want to require all users to be
	 * authenticated or not, which filter (AuthTokenFilter) and when we want it to
	 * work (filter before UsernamePasswordAuthenticationFilter), which Exception
	 * Handler is chosen (AuthEntryPointJwt).
	 */
	@Override
	protected void configure(HttpSecurity http) throws Exception {
		http.cors().and().csrf().disable() //
				.exceptionHandling().authenticationEntryPoint(unauthorizedHandler).and() //
				.sessionManagement().sessionCreationPolicy(SessionCreationPolicy.STATELESS).and() //
				.authorizeRequests().antMatchers("/api/auth/**").permitAll()//
				.antMatchers("/api/test/**").permitAll() //
				.anyRequest().authenticated();
		
		http.addFilterBefore(authenticationJwtTokenFilter(), UsernamePasswordAuthenticationFilter.class);
	}

}
