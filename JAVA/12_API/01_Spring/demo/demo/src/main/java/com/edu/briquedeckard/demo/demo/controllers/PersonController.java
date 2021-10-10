package com.edu.briquedeckard.demo.demo.controllers;

import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.edu.briquedeckard.demo.demo.data.repositories.PersonRepository;
import java.util.List;
import java.util.Optional;

import com.edu.briquedeckard.demo.demo.models.entities.Person;

@RestController
public class PersonController {

    // Property to hold the repository
    public PersonRepository People;

    // Constructor that receives the repository via dependency injection
    public PersonController(PersonRepository people) {
        this.People = people;
    }

    // Get to /people returns list of people
    @GetMapping("/people")
    public List<Person> getPeople() {
        return People.findAll(); // Returns all people
    }

    // Get to /people/id return a person by its id
    @GetMapping("/people/{id}")
    public Person getPeople(@PathVariable Long id) {
        return (Person) People.findById(id).get();
    }

    // Post to /people, takes in request body which must be of type Person
    @PostMapping("/people")
    public List<Person> createPerson(@RequestBody Person newPerson) {
        People.save(newPerson); // Creates new person
        return People.findAll();
    }

    // Put to /people/:id, takes in the body and url param id
    @PutMapping("/people/{id}")
    public List<Person> updatePerson(@RequestBody Person updatedPerson, @PathVariable Long id) {
        // search for the person by id, map over the person, alter them, then save
        People.findById(id).map(person -> {
            person.setName(updatedPerson.getName());
            person.setAge(updatedPerson.getAge());
            return People.save(person); // Save and returns edits
        });

        return People.findAll();
    }

    // Delete request to /people/:id, deletes person based on id param
    @DeleteMapping("/people/{id}")
    public List<Person> deletePerson(@PathVariable Long id) {
        People.deleteById(id);
        return People.findAll();
    }
}
