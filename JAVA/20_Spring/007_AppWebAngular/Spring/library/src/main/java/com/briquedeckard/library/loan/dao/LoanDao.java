package com.briquedeckard.library.loan.dao;

import java.time.LocalDate;
import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import com.briquedeckard.library.loan.Loan;
import com.briquedeckard.library.loan.LoanStatus;

@Repository
public interface LoanDao extends JpaRepository<Loan, Integer> {

	/**
	 * Find all loans that end before a date.
	 * 
	 * @param maxEndDate
	 * @return
	 */
	public List<Loan> findByEndDateBefore(LocalDate maxEndDate);

	@Query("SELECT lo " //
			+ "FROM Loan lo " //
			+ "INNER JOIN lo.pk.customer c " //
			+ "WHERE UPPER(c.email) = UPPER(?1) " //
			+ "AND lo.status = ?2 ")
	public List<Loan> getAllOpenLoansOfThisCustomer(String email, LoanStatus status);

	@Query("SELECT lo " //
			+ "FROM Loan lo " //
			+ "INNER JOIN lo.pk.book b " //
			+ "INNER JOIN lo.pk.customer c " //
			+ "WHERE b.id = ?1 " //
			+ "AND c.id = ?2 " //
			+ "AND lo.status = ?3 ")
	public Loan getLoanByCriteria(Integer bookId, Integer customerId, LoanStatus status);

}
