package com.briquedeckard.library.customer.controller;

import java.time.LocalDate;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

import org.modelmapper.ModelMapper;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.mail.MailException;
import org.springframework.mail.SimpleMailMessage;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.util.StringUtils;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.util.UriComponentsBuilder;

import com.briquedeckard.library.customer.Customer;
import com.briquedeckard.library.customer.dto.CustomerDTO;
import com.briquedeckard.library.customer.service.impl.CustomerServiceImpl;
import com.briquedeckard.library.mail.MailDTO;

@CrossOrigin(origins = "http://localhost:4200")
@RestController
@RequestMapping("/rest/customer/api")
public class CustomerRestController {
	public static final Logger LOGGER = LoggerFactory.getLogger(CustomerRestController.class);

	@Autowired
	private CustomerServiceImpl customerService;

	@Autowired
	private JavaMailSender javaMailSender;

	@PostMapping("/addCustomer")
	public ResponseEntity<CustomerDTO> createNewCustomer(@RequestBody CustomerDTO customerDTORequest) {
		// If the customer already exists, return 409 - CONFLICT
		Customer existingCustomer = customerService.findCustomerByEmail(customerDTORequest.getEmail());
		if (existingCustomer != null) {
			return new ResponseEntity<CustomerDTO>(HttpStatus.CONFLICT);
		}

		// Else, transform the DTO and save the entity
		Customer customerRequest = mapCustomerDTOToCustomer(customerDTORequest);
		customerRequest.setCreationDate(LocalDate.now());
		Customer customerResponse = customerService.saveCustomer(customerRequest);
		// If the customer has been created, return 201 - CREATED
		if (customerResponse != null) {
			CustomerDTO customerDTO = mapCustomerToCustomerDTO(customerResponse);
			return new ResponseEntity<CustomerDTO>(customerDTO, HttpStatus.CREATED);
		}
		// Else return 304 - Not modified
		return new ResponseEntity<CustomerDTO>(HttpStatus.NOT_MODIFIED);

	}

	@PutMapping("/updateCustomer")
	public ResponseEntity<CustomerDTO> updateCustomer(@RequestBody CustomerDTO customerDTORequest) {
		// if the id does not exist, return 404 - NOT FOUND
		if (!customerService.checkIfIdexists(customerDTORequest.getId())) {
			return new ResponseEntity<CustomerDTO>(HttpStatus.NOT_FOUND);
		}

		Customer customerRequest = mapCustomerDTOToCustomer(customerDTORequest);
		Customer customerResponse = customerService.updateCustomer(customerRequest);
		// If the response was given, return 200 - OK
		if (customerResponse != null) {
			CustomerDTO customerDTO = mapCustomerToCustomerDTO(customerResponse);
			return new ResponseEntity<CustomerDTO>(HttpStatus.OK);
		}
		// Else, return 304 - Not modified
		return new ResponseEntity<CustomerDTO>(HttpStatus.NOT_MODIFIED);
	}

	@DeleteMapping("/deleteCustomer/{customerId}")
	public ResponseEntity<String> deleteCustomer(@PathVariable Integer customerId) {
		customerService.deleteCustomer(customerId);
		// return 201 - No content
		return new ResponseEntity<String>(HttpStatus.NO_CONTENT);
	}

	@GetMapping("/paginatedSearch")
	public ResponseEntity<List<CustomerDTO>> searchCustomers(@RequestParam("beginPage") int beginPage,
			@RequestParam("endPage") int endPage) {
		Page<Customer> customers = customerService.getPaginatedCustomersList(beginPage, endPage);
		// If there is a result, convert it and return 200 - OK and the entities as a
		// list
		if (customers != null) {
			List<CustomerDTO> customerDTOs = customers.stream().map(customer -> {
				return mapCustomerToCustomerDTO(customer);
			}).collect(Collectors.toList());
			return new ResponseEntity<List<CustomerDTO>>(customerDTOs, HttpStatus.OK);
		}
		// else, return 201 - No content
		return new ResponseEntity<List<CustomerDTO>>(HttpStatus.NO_CONTENT);
	}

	@GetMapping("/searchByEmail")
	public ResponseEntity<CustomerDTO> searchCustomerByEmail(@RequestParam("email") String email) {
		Customer customer = customerService.findCustomerByEmail(email);
		// if there is a result, convert it and return 200 - OK and the entity as a dto
		if (customer != null) {
			CustomerDTO customerDTO = mapCustomerToCustomerDTO(customer);
			return new ResponseEntity<CustomerDTO>(customerDTO, HttpStatus.OK);
		}
		// else return 201 - No content
		return new ResponseEntity<CustomerDTO>(HttpStatus.NO_CONTENT);
	}

	@GetMapping("/searchByLastName")
	public ResponseEntity<List<CustomerDTO>> searchBookByLastName(@RequestParam("lastName") String lastName) {
		List<Customer> customers = customerService.findCustomerByLastName(lastName);
		// If there is a result, convert it and return it with a 200 - OK
		if (customers != null) {
			List<CustomerDTO> customerDTOs = customers.stream().map(customer -> {
				return mapCustomerToCustomerDTO(customer);
			}).collect(Collectors.toList());
			return new ResponseEntity<List<CustomerDTO>>(customerDTOs, HttpStatus.OK);
		}
		// else return 201 - No content
		return new ResponseEntity<List<CustomerDTO>>(HttpStatus.NO_CONTENT);
	}

	@GetMapping("/getAllCustomers")
	public ResponseEntity<List<CustomerDTO>> getAllCustomers() {
		List<Customer> customers = customerService.findAllCustomers();
		// If there is a result, convert it and return it with a 200 - OK
		if (customers != null) {
			List<CustomerDTO> customerDTOs = customers.stream().map(customer -> {
				return mapCustomerToCustomerDTO(customer);
			}).collect(Collectors.toList());
			return new ResponseEntity<List<CustomerDTO>>(customerDTOs, HttpStatus.OK);
		}
		// else return 201 - No content
		return new ResponseEntity<List<CustomerDTO>>(HttpStatus.NO_CONTENT);
	}

	@PutMapping("/sendEmailToCustomer")
	public ResponseEntity<Boolean> sendMailToCustomer(@RequestBody MailDTO loanMailDto,
			UriComponentsBuilder uriComponentBuilder) {
		Customer customer = customerService.findCustomerById(loanMailDto.getCustomerId());
		if (customer == null) {
			String errorMessage = "The select Customer for sending email is not found in the database";
			LOGGER.info(errorMessage);
			return new ResponseEntity<Boolean>(false, HttpStatus.NOT_FOUND);
		} else if (customer != null && StringUtils.isEmpty(customer.getEmail())) {
			String errorMessage = "No existing email for the selected customer fpr sending email to";
			LOGGER.info(errorMessage);
			return new ResponseEntity<Boolean>(false, HttpStatus.NOT_FOUND);
		}

		SimpleMailMessage mail = new SimpleMailMessage();
		mail.setFrom(loanMailDto.MAIL_FROM);
		mail.setTo(customer.getEmail());
		mail.setSentDate(new Date());
		mail.setSubject(loanMailDto.getEmailSubject());
		mail.setText(loanMailDto.getEmailContent());

		try {
			javaMailSender.send(mail);
		} catch (MailException e) {
			return new ResponseEntity<Boolean>(false, HttpStatus.FORBIDDEN);
		} catch (Exception e) {
			String errorMessage = e.getMessage();
			LOGGER.info(errorMessage);
		}
		return new ResponseEntity<Boolean>(true, HttpStatus.OK);

	}

	private CustomerDTO mapCustomerToCustomerDTO(Customer customer) {
		ModelMapper mapper = new ModelMapper();
		CustomerDTO customerDTO = mapper.map(customer, CustomerDTO.class);
		return customerDTO;
	}

	private Customer mapCustomerDTOToCustomer(CustomerDTO customerDTO) {
		ModelMapper mapper = new ModelMapper();
		Customer customer = mapper.map(customerDTO, Customer.class);
		return customer;
	}

}
