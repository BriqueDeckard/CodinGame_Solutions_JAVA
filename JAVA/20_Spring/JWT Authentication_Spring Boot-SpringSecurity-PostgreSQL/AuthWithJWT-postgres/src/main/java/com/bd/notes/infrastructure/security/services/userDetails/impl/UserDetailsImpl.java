package com.bd.notes.infrastructure.security.services.userDetails.impl;

import java.util.Collection;
import java.util.List;
import java.util.Objects;
import java.util.stream.Collectors;

import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.UserDetails;

import com.bd.notes.domain.aggregates.user.User;
import com.fasterxml.jackson.annotation.JsonIgnore;

/**
 * Provides core user information.
 * 
 * Implementations are not used directly by Spring Security for security
 * purposes. Theysimply store user information which is later encapsulated into
 * Authenticationobjects. This allows non-security related user information
 * (such as email addresses,telephone numbers etc) to be stored in a convenient
 * location.
 * 
 * Concrete implementations must take particular care to ensure the non-null
 * contractdetailed for each method is enforced.
 * 
 * @author pierr
 *
 */
public class UserDetailsImpl implements UserDetails {

	/**
	 * 
	 */
	private static final long serialVersionUID = -4769412146639517023L;

	private Long id;
	private String username;
	private String email;

	@JsonIgnore
	private String password;
	// Represents all authorities granted to an Authentication object. 
	private Collection<? extends GrantedAuthority> authorities;

	public UserDetailsImpl(Long id, String username, String email, String password,
			Collection<? extends GrantedAuthority> authorities) {
		this.id = id;
		this.username = username;
		this.email = email;
		this.password = password;
		this.authorities = authorities;
	}

	public static UserDetailsImpl build(User user) {
		// Convert Set<Role> into
		// List<GrantedAuthority>.
		List<GrantedAuthority> authorities = user.getRoles().stream()
				.map(role -> new SimpleGrantedAuthority(role.getName().name()))//
				.collect(Collectors.toList());

		return new UserDetailsImpl(user.getId(), user.getUsername(), user.getEmail(), user.getPassword(), authorities);
	}

	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	@Override
	public Collection<? extends GrantedAuthority> getAuthorities() {
		return authorities;
	}

	@Override
	public String getPassword() {
		return this.password;
	}

	@Override
	public String getUsername() {
		return this.username;
	}

	@Override
	public boolean isAccountNonExpired() {
		return true;
	}

	@Override
	public boolean isAccountNonLocked() {
		return true;
	}

	@Override
	public boolean isCredentialsNonExpired() {
		return true;
	}

	@Override
	public boolean isEnabled() {
		return true;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj) {
			return true;
		}
		if (obj == null || getClass() != obj.getClass()) {
			return false;
		}
		UserDetailsImpl user = (UserDetailsImpl) obj;
		return Objects.equals(id, user.id);
	}

}
