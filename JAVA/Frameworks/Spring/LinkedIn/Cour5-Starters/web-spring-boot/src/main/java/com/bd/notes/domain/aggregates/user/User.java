package com.bd.notes.domain.aggregates.user;

public interface User {

	String getFirstName();

	void setFirstName(String firstName);

	String getLastName();

	void setLastName(String lastName);

	long getId();

	void setId(long id);

}