package com.briquedeckard.library.loan.service;

import java.time.LocalDate;
import java.util.List;

import com.briquedeckard.library.loan.Loan;
import com.briquedeckard.library.loan.LoanStatus;
import com.briquedeckard.library.loan.dto.SimpleLoanDTO;

public interface LoanService {
	public List<Loan> findAllLoansByEndDateBefore(LocalDate maxEndDate);

	public List<Loan> getAllOpenLoansOfThisCustomer(String email, LoanStatus status);

	public Loan getOpenedLoan(SimpleLoanDTO simpleLoanDTO);

	public boolean checkIfLoanExists(SimpleLoanDTO simpleLoanDTO);

	public Loan saveLoan(Loan loan);

	public void closeLoan(Loan loan);

}
