package com.edu.briquedeckard.demo.demo.data.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import com.edu.briquedeckard.demo.demo.models.entities.Person;
/**
 * the repository will act as the interface between our code and the table
 */
public interface PersonRepository extends JpaRepository<Person, Long> {

}
