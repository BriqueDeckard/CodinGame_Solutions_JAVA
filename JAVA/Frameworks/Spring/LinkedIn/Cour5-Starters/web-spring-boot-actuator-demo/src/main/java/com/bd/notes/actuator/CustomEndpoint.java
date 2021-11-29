package com.bd.notes.actuator;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.actuate.endpoint.annotation.Endpoint;
import org.springframework.boot.actuate.endpoint.annotation.ReadOperation;
import org.springframework.stereotype.Component;

import com.bd.notes.services.SomeServiceImpl;

@Component
@Endpoint(id = "custom")
public class CustomEndpoint {

	@Autowired
	SomeServiceImpl service;

	@ReadOperation
	public ExempleEndpoint getExempleEndpoint() {
		ExempleEndpoint exempleEndpoint = new ExempleEndpoint();
		exempleEndpoint.message = "My custom actuator";
		exempleEndpoint.values = service.getEntities();
		return exempleEndpoint;
	}

	public class ExempleEndpoint {
		private String message;

		private List<String> values;

		public List<String> getValues() {
			return values;
		}

		public void setValues(List<String> values) {
			this.values = values;
		}

		public String getMessage() {
			return message;
		}

		public void setMessage(String message) {
			this.message = message;
		}

	}

}
