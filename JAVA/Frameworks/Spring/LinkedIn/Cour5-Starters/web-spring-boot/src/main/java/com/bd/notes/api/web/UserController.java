package com.bd.notes.api.web;

import java.util.List;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.bd.notes.application.services.user.UserService;
import com.bd.notes.domain.aggregates.user.User;

@Controller
@RequestMapping("/web/") // intercepte toutes les requêtes de l'application
public class UserController {
	private final UserService userService;

	public UserController(UserService userService) {
		super();
		this.userService = userService;
	}

	@GetMapping("users") // intercepte "GET~/users"
	public String getUsers(Model model) {
		// Récupère la liste des users
		List<User> users = userService.getAllUsers();
		// on la passe au modele
		model.addAttribute("users", users);
		// on retourne une vue
		return "UserView";
	}

}
