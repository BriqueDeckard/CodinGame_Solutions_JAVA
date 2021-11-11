package com.briquedeckard.library;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.mail.javamail.JavaMailSenderImpl;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.servlet.config.annotation.CorsRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;

import springfox.documentation.builders.ApiInfoBuilder;
import springfox.documentation.builders.PathSelectors;
import springfox.documentation.builders.RequestHandlerSelectors;
import springfox.documentation.service.ApiInfo;
import springfox.documentation.service.Contact;
import springfox.documentation.spi.DocumentationType;
import springfox.documentation.spring.web.plugins.Docket;
import springfox.documentation.swagger2.annotations.EnableSwagger2;

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
 * -@CompoenentScan(basePackages = "com.gkemayo.library") : cette annotation
 * indique à Spring de scanner le package et les sous-packages passés en
 * paramètre pour rechercher des classes qu'elle pourrait injecter comme beans
 * dans l'application. Ces classes peuvent être marquées par des annotations
 * telles @Component, @RestController, @Service, @Repository, @Configuration,
 * etc. Lorsque l'annotation @ComponentScan ne prend pas de paramètre, alors
 * c'est le package de la classe sur laquelle elle est apposée qui est considéré
 * ; -@EnableAutoConfiguration : cette annotation permet de détecter et
 * d'injecter comme bean, certaines classes contenues dans les dépendances du
 * classpath de votre application.
 * 
 * @author pierr
 *
 */
@SpringBootApplication
@EnableSwagger2
public class LibraryApplication{
	/**
	 * Docket est le bean qui permet de configurer les données du rendu graphique de
	 * la documentation JSON de notre application. Il propose un ensemble
	 * d'attributs permettant de configurer : les packages contenant l'API REST
	 * concerné par la documentation Swagger (ici, com.gkemayo.library), les URI
	 * spécifiques des API REST à documenter (ici, tous les URI seront documentés :
	 * PathSelectors.any()), et d'autres informations générales à afficher (titre
	 * d'entête de la page, contact du/des contributeurs, version de l'API REST
	 * documentée, etc.).
	 * 
	 * @return
	 */
	@Bean
	public Docket api() {
		return new Docket(DocumentationType.SWAGGER_2).select()
				.apis(RequestHandlerSelectors.basePackage("com.briquedeckard.library")).paths(PathSelectors.any())
				.build().apiInfo(apiInfo());
	}

	private ApiInfo apiInfo() {
		return new ApiInfoBuilder().title("Library Spring boot REST API Documentation")
				.description("REST APIs for Managing Books loans in a Library")
				.contact(new Contact("Pierre ANTOINE", "https://brique.com", "erreipantoine@gmail.com")).version("1.0")
				.build();
	}

	@Bean
	public JavaMailSender javaMailSender() {
		return new JavaMailSenderImpl();
	}

	public static void main(String[] args) {
		SpringApplication.run(LibraryApplication.class, args);
	}
	
	

}
