package com.ecommerce.microcommerce.configuration;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import springfox.documentation.builders.PathSelectors;
import springfox.documentation.builders.RequestHandlerSelectors;
import springfox.documentation.spi.DocumentationType;
import springfox.documentation.spring.web.plugins.Docket;
import springfox.documentation.swagger2.annotations.EnableSwagger2;

// @Configuration annotation applied to the class allows to replace a classic xml  configuration file.
// Docket class, that manage all the configurations offers us to customize Swagger
@Configuration
@EnableSwagger2
public class SwaggerConfig {
    // Start with a Docket object initilization.
    @Bean
    public Docket api() {
        return new Docket(DocumentationType.SWAGGER_2)
                // select initializes a class name ApiSelectorBuilder. This class offers access to
                // the customization methods
                .select()
                // apis is the first notable method. It allows to filter the exposed documentation.
                // by the controllers
                // As it, you can hide the private documentation of your API.
                //
                // RequestHandlerSelectors is a predicate
                // In this case, we use 'any' that will always return true. --> All the classes in all the packages
                // RequestHandlerSelectors offers severals others methods like annotationPresent  that allows
                // to define a parameter annotation
                // Swagger will document only the used classes.
                // The most used is  basePackage that allow to sort by the package.
                .apis(RequestHandlerSelectors.basePackage("com.ecommerce.microcommerce.web"))
                // Path : this method gives access to another way of filtering : by query URI. As it, you can
                // ask to swagger to only document the methods that correspond to queries starting by
                // a sequence like "/public"
                .paths(PathSelectors.regex("/produits.*"))
                .build();
    }
}
