package com.briquedeckard.library.customer.dao;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.briquedeckard.library.customer.Customer;

@Repository
public interface CustomerDao extends JpaRepository<Customer, Integer> {

	/**
	 * Find a customer by its email
	 * 
	 * @param email
	 * @return
	 */
	public Customer findCustomerByEmailIgnoreCase(String email);

	/**
	 * Finds all customers by their last name.
	 * 
	 * @param lastName
	 * @return
	 */
	public List<Customer> findCustomerByLastNameIgnoreCase(String lastName);

}
