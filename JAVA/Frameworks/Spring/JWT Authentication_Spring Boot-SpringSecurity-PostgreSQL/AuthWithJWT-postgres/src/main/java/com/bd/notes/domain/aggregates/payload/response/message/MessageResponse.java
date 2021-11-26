package com.bd.notes.domain.aggregates.payload.response.message;

import com.fasterxml.jackson.annotation.JsonProperty;

public class MessageResponse {
	@JsonProperty("message")
	private String message;

	public MessageResponse(String message) {
		this.message = message;
	}

	public String getMessage() {
		return message;
	}

	public void setMessage(String message) {
		this.message = message;
	}
}
