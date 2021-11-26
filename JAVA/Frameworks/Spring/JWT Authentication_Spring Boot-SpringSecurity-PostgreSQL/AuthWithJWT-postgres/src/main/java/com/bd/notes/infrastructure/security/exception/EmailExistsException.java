package com.bd.notes.infrastructure.security.exception;

public class EmailExistsException extends Exception {

	/**
	 * 
	 */
	private static final long serialVersionUID = -6009066483962623465L;

	public EmailExistsException() {
		super();
		// TODO Auto-generated constructor stub
	}

	public EmailExistsException(String message, Throwable cause, boolean enableSuppression,
			boolean writableStackTrace) {
		super(message, cause, enableSuppression, writableStackTrace);
		// TODO Auto-generated constructor stub
	}

	public EmailExistsException(String message, Throwable cause) {
		super(message, cause);
		// TODO Auto-generated constructor stub
	}

	public EmailExistsException(String message) {
		super(message);
		// TODO Auto-generated constructor stub
	}

	public EmailExistsException(Throwable cause) {
		super(cause);
		// TODO Auto-generated constructor stub
	}

}
