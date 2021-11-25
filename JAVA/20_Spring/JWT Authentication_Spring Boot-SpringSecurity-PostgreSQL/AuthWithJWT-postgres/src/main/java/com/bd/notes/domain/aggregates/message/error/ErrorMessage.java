package com.bd.notes.domain.aggregates.message.error;

import java.util.Date;

public class ErrorMessage {
	public int getStatus() {
		return statusCode;
	}

	public void setStatus(int status) {
		this.statusCode = status;
	}

	public Date getDate() {
		return timestamp;
	}

	public void setDate(Date date) {
		this.timestamp = date;
	}

	public String getMessage() {
		return message;
	}

	public void setMessage(String message) {
		this.message = message;
	}

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	private int statusCode;
	private Date timestamp;
	private String message;
	private String description;

	public ErrorMessage(int i, Date date, String message, String description) {
		super();
		this.statusCode = i;
		this.timestamp = date;
		this.message = message;
		this.description = description;
	}

}
