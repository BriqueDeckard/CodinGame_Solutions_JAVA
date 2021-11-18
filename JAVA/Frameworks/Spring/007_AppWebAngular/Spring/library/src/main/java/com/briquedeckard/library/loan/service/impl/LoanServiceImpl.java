/**
 * 
 */
package com.briquedeckard.library.loan.service.impl;

import java.time.LocalDate;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.briquedeckard.library.loan.Loan;
import com.briquedeckard.library.loan.LoanStatus;
import com.briquedeckard.library.loan.dao.LoanDao;
import com.briquedeckard.library.loan.dto.SimpleLoanDTO;
import com.briquedeckard.library.loan.service.LoanService;


/**
 * @author pierr
 *
 */
@Service("loanService")
@Transactional
public class LoanServiceImpl implements LoanService {

	@Autowired
	private LoanDao loanDao;

	@Override
	public List<Loan> findAllLoansByEndDateBefore(LocalDate maxEndDate) {
		return loanDao.findByEndDateBefore(maxEndDate);
	}

	@Override
	public List<Loan> getAllOpenLoansOfThisCustomer(String email, LoanStatus status) {
		return loanDao.getAllOpenLoansOfThisCustomer(email, status);
	}

	@Override
	public Loan saveLoan(Loan loan) {
		return loanDao.save(loan);
	}

	@Override
	public void closeLoan(Loan loan) {
		loanDao.save(loan);
	}

	@Override
	public Loan getOpenedLoan(SimpleLoanDTO simpleLoanDTO) {
		return loanDao.getLoanByCriteria(simpleLoanDTO.getBookId(), simpleLoanDTO.getCustomerId(), LoanStatus.OPEN);
	}

	@Override
	public boolean checkIfLoanExists(SimpleLoanDTO simpleLoanDTO) {
		Loan loan = loanDao.getLoanByCriteria(simpleLoanDTO.getBookId(), simpleLoanDTO.getCustomerId(),
				LoanStatus.OPEN);
		if (loan == null) {
			return false;
		}
		return true;
	}

}
