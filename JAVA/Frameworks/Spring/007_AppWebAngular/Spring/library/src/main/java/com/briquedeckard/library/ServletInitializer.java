package com.briquedeckard.library;

import org.springframework.boot.builder.SpringApplicationBuilder;
import org.springframework.boot.web.servlet.support.SpringBootServletInitializer;

/**
 * Toute application web doit se voir configurer une classe Servlet dont le but
 * est d'intercepter toute requête HTTP -- venant d'un client web en direction
 * d'un serveur d'application -- dans l'optique de la contrôler et de gérer
 * l'intercommunication. Spring Boot crée automatiquement pour tout projet web
 * la classe ServletInitializer héritant de SpringBootServletInitializer
 * correspondant à la servlet de notre application et utilisant toutes les
 * ressources de la classe de démarrage, dans le cas d'espèce
 * LibraryApplication.
 * 
 * @author pierr
 *
 */
public class ServletInitializer extends SpringBootServletInitializer {

	@Override
	protected SpringApplicationBuilder configure(SpringApplicationBuilder application) {
		return application.sources(LibraryApplication.class);
	}

}
