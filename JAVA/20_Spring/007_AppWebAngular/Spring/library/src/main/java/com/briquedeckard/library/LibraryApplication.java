package com.briquedeckard.library;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

/**
 * Cette classe est le point d'entrée de notre application. C'est-à-dire, la
 * classe utilisée par Spring Boot pour démarrer (booter) notre application. En
 * effet, Spring Boot marque toute classe comme point de démarrage d'une
 * application par l'annotation @SpringBootApplication. Cette annotation propre
 * à Spring Boot est en réalité l’agrégation de trois annotations Spring qui
 * sont :
 * 
 * -@configuration : cette annotation indique à Spring de considérer la classe
 * sur laquelle elle est apposée comme étant un bean dans lequel d'autres beans
 * peuvent être déclarés ; 
 * 
 * -@CompoenentScan(basePackages =
 * "com.gkemayo.library") : cette annotation indique à Spring de scanner le
 * package et les sous-packages passés en paramètre pour rechercher des classes
 * qu'elle pourrait injecter comme beans dans l'application. Ces classes peuvent
 * être marquées par des annotations
 * telles @Component, @RestController, @Service, @Repository, @Configuration,
 * etc. Lorsque l'annotation @ComponentScan ne prend pas de paramètre, alors
 * c'est le package de la classe sur laquelle elle est apposée qui est considéré
 * ; 
 * -@EnableAutoConfiguration : cette annotation permet de détecter et
 * d'injecter comme bean, certaines classes contenues dans les dépendances du
 * classpath de votre application.
 * 
 * @author pierr
 *
 */
@SpringBootApplication
public class LibraryApplication {

	public static void main(String[] args) {
		SpringApplication.run(LibraryApplication.class, args);
	}

}
