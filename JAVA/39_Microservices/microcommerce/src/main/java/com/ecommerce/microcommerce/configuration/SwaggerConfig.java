package com.ecommerce.microcommerce.configuration;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import springfox.documentation.builders.PathSelectors;
import springfox.documentation.builders.RequestHandlerSelectors;
import springfox.documentation.spi.DocumentationType;
import springfox.documentation.spring.web.plugins.Docket;
import springfox.documentation.swagger2.annotations.EnableSwagger2;
/*
L'annotation  @Configuration  appliquée à la classe permet de remplacer un fichier de configuration classique en XML.
Elle nous donne accès à plusieurs méthodes très intéressantes pour la personnalisation de Swagger, grâce à la classe
Docket qui gère toutes les configurations.

On commence alors par initialiser un objet Docket en précisant que nous souhaitons utiliser swagger 2.

select permet d'initialiser une classe du nom de ApiSelectorBuilder qui donne accès aux méthodes de personnalisation
suivantes. Nous vous attardez pas sur cette méthode, elle n'est d'aucune utilité pour la suite.

apis est la première méthode importante. Elle permet de filtrer la documentation à exposer selon les contrôleurs.
Ainsi, vous pouvez cacher la documentation d'une partie privée ou interne de votre API. Dans ce cas, nous avons
utilisé RequestHandlerSelectors.any().

RequestHandlerSelectors est un prédicat (introduit depuis java 8) qui permet de retourner TRUE ou FALSE selon la
 conditions utilisée. Dans ce cas, nous avons utilisé any qui retournera toujours TRUE. En d'autres termes, nous
 indiquons vouloir documenter toutes les classes dans tous les packages. RequestHandlerSelectors offre plusieurs
 autres méthodes comme annotationPresent qui vous permet de définir une annotation en paramètre. Swagger ne
 documentera alors que les classes qu'il utilise. La plus utilisée est basePackage qui permet de trier
 selon le Package. Nous allons voir un exemple juste après.

paths : cette méthode donne accès à une autre façon de filtrer : selon l'URI des requêtes. Ainsi, vous pouvez,
par exemple, demander à Swagger de ne documenter que les méthodes qui répondent à des requêtes commençant
par "/public" .
 */
@Configuration
@EnableSwagger2
public class SwaggerConfig {
    @Bean
    public Docket api() {
        return new Docket(DocumentationType.SWAGGER_2)
                .select()
                .apis(RequestHandlerSelectors.basePackage("com.ecommerce.microcommerce.web"))
                .paths(PathSelectors.regex("/produits.*"))
                .build();
    }
}
