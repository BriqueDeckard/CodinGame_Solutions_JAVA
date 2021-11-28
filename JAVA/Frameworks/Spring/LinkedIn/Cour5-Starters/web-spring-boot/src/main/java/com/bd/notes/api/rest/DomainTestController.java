package com.bd.notes.api.rest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.bd.notes.application.services.user.UserApplicationService;

@RestController
@RequestMapping("test/domain") // intercepte les requêtes "test/domain/"
public class DomainTestController {
	
	
	public DomainTestController(UserApplicationService applicationService) {
		super();
		this.applicationService = applicationService;
	}

	@Autowired
	private UserApplicationService applicationService;
	
	@GetMapping() // intercepte "GET~/test/domain"
	public String domainOperation() {
		String data =  applicationService.someDomainOperation();
		return data;
	}

}
