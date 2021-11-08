package com.briquedeckard.library.loan.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.util.UriComponentsBuilder;

import com.briquedeckard.library.book.Book;
import com.briquedeckard.library.customer.Customer;
import com.briquedeckard.library.loan.Loan;
import com.briquedeckard.library.loan.LoanId;
import com.briquedeckard.library.loan.LoanStatus;
import com.briquedeckard.library.loan.dto.LoanDTO;
import com.briquedeckard.library.loan.dto.SimpleLoanDTO;
import com.briquedeckard.library.loan.service.impl.LoanServiceImpl;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import io.swagger.annotations.ApiResponse;
import io.swagger.annotations.ApiResponses;
import io.swagger.v3.oas.annotations.parameters.RequestBody;

@RestController
@RequestMapping("/rest/loan/api")
@Api(value = "Loan Rest Controller: contains all operations for managing loans.")
public class LoanRestController {

	public static final Logger LOGGER = LoggerFactory.getLogger(LoanRestController.class);

	@Autowired
	private LoanServiceImpl loanService;

	@PostMapping("/addLoan")
	@ApiOperation(value = "Add a new Loan in the system", response = LoanDTO.class)
	@ApiResponses(value = { @ApiResponse(code = 409, message = "Conflict: the Loan already exist"),
			@ApiResponse(code = 201, message = "Created: the loan is successfully inserted"),
			@ApiResponse(code = 304, message = "Not Modified: the loan is unsuccessfully inserted") })
	public ResponseEntity<Boolean> createNewLoan(@RequestBody SimpleLoanDTO simpleLoanDTORequest,
			UriComponentsBuilder uriComponentsBuilder) {
		boolean isLoanExists = loanService.checkIfLoanExists(simpleLoanDTORequest);
		// If loan exist, return 409 - CONFLICT
		if (isLoanExists) {
			return new ResponseEntity<Boolean>(false, HttpStatus.CONFLICT);
		}
		Loan loanRequest = mapSimpleLoanDTOToLoan(simpleLoanDTORequest);
		Loan loan = loanService.saveLoan(loanRequest);
		// If loan has been successfully created, return 201 - CREATED
		if (loan != null) {
			return new ResponseEntity<Boolean>(true, HttpStatus.CREATED);
		}
		// else return 304 - NOT MODIFIED
		return new ResponseEntity<Boolean>(false, HttpStatus.NOT_MODIFIED);
	}

	private Loan mapSimpleLoanDTOToLoan(SimpleLoanDTO simpleLoanDTO) {
		Loan loan = new Loan();
		// --- BOOK ---
		Book book = new Book();
		book.setId(simpleLoanDTO.getBookId());
		// --- CUSTOMER ---
		Customer customer = new Customer();
		customer.setId(simpleLoanDTO.getCustomerId());
		// --- LOAN ---
		LoanId loanId = new LoanId(book, customer);
		loan.setPk(loanId);
		loan.setBeginDate(simpleLoanDTO.getBeginDate());
		loan.setEndDate(simpleLoanDTO.getEndDate());
		loan.setStatus(LoanStatus.OPEN);
		return loan;
	}

}
