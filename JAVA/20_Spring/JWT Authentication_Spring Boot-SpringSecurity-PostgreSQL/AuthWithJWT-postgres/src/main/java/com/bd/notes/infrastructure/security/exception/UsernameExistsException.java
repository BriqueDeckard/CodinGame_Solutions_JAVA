package com.bd.notes.infrastructure.security.exception;

public class UsernameExistsException extends Exception {

	/**
	 * 
	 */
	private static final long serialVersionUID = 6539846833432205866L;

	public UsernameExistsException() {
		super();
		// TODO Auto-generated constructor stub
	}

	public UsernameExistsException(String message, Throwable cause, boolean enableSuppression,
			boolean writableStackTrace) {
		super(message, cause, enableSuppression, writableStackTrace);
		// TODO Auto-generated constructor stub
	}

	public UsernameExistsException(String message, Throwable cause) {
		super(message, cause);
		// TODO Auto-generated constructor stub
	}

	public UsernameExistsException(String message) {
		super(message);
		// TODO Auto-generated constructor stub
	}

	public UsernameExistsException(Throwable cause) {
		super(cause);
		// TODO Auto-generated constructor stub
	}
	

}
