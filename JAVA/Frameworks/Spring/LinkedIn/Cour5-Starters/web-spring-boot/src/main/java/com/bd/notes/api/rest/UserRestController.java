package com.bd.notes.api.rest;

import java.util.List;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.bd.notes.application.services.user.UserService;
import com.bd.notes.domain.aggregates.user.User;
import com.bd.notes.domain.aggregates.user.impl.UserImpl;

@RestController
@RequestMapping("api/user") // intercepte toutes les requêtes de l'application
public class UserRestController {



	private final UserService userService;

	public UserRestController(UserService userService) {
		super();
		this.userService = userService;

	}

	@GetMapping() // intercepte "GET~/rest/users"
	public List<User> getUsers(Model model) {
		// Comme c'est un controller REST, on retourne directement la liste
		return this.userService.getAllUsers();
	}

	@PostMapping // intercepte "POST~/rest/
	public void addUser(@RequestBody UserImpl user) {
		userService.addUser(user);
	}

	@GetMapping(path = "{id}") // intercepte "GET~/rest/{id}"
	public User getUserById(@PathVariable("id") Long id) {
		return userService.findUserById(id);
	}

	@DeleteMapping(path = "{id}") // intercepte "GET~/rest/{id}"
	public void deleteUserById(@PathVariable("id") Long id) {
		userService.deleteUser(id);
	}

	@PutMapping
	public void updateUser(@RequestBody User user) throws Exception {
		try {
			userService.updateUser(user);
		} catch (Exception e) {
			throw e;
		}

	}

}
