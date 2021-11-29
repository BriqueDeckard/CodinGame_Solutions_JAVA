package com.bd.notes.api.rest;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class EchoController {

	@GetMapping("/echo")
	public String echo(String input) {
		return input;
	}
}
