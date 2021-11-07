package com.briquedeckard.library.customer.controller;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.briquedeckard.library.customer.service.impl.CustomerServiceImpl;

@RestController
@RequestMapping("/rest/customer/api")
public class CustomerRestController {
	public static final Logger LOGGER = LoggerFactory.getLogger(CustomerRestController.class);
	
	@Autowired
	private CustomerServiceImpl customerService;
	
	@Autowired
	private JavaMailSender javaMailSender;
}
