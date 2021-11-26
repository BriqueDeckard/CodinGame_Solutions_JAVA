package com.bd.notes.application.contracts;

import com.bd.notes.domain.aggregates.user.User;

public class UserDTO implements User {

	private String firstName;
	private String lastName;
	private long id;

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public UserDTO(String firstName, String lastName, long id) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = id;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

}
