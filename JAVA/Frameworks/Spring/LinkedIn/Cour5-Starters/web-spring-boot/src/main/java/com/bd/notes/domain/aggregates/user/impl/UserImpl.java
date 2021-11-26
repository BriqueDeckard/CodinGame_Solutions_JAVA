package com.bd.notes.domain.aggregates.user.impl;

import java.io.Serializable;

import com.bd.notes.domain.aggregates.user.User;

public class UserImpl implements Serializable, User {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String firstName;
	private String lastName;
	private long id;

	public UserImpl() {

	}

	public UserImpl(String firstName, String lastName, long id) {
		super();
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = id;
	}

	public UserImpl(String firstName, String lastName) {
		super();
		this.firstName = firstName;
		this.lastName = lastName;
	}

	@Override
	public String getFirstName() {
		return firstName;
	}

	@Override
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	@Override
	public String getLastName() {
		return lastName;
	}

	@Override
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	@Override
	public long getId() {
		return this.id;
	}

	@Override
	public void setId(long id) {
		this.id = id;
	}

}
