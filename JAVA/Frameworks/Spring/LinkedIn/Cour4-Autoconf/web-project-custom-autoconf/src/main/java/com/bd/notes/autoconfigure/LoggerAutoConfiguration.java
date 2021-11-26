package com.bd.notes.autoconfigure;

import org.springframework.boot.autoconfigure.condition.ConditionalOnClass;
import org.springframework.boot.autoconfigure.condition.ConditionalOnMissingBean;
import org.springframework.boot.context.properties.EnableConfigurationProperties;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import com.bd.notes.service.LogService;
import com.bd.notes.service.impl.LogServiceImpl;
import com.bd.notes.service.properties.LogProperties;

@Configuration
@ConditionalOnClass(LogService.class) // <-- Cette autoconf s'applique uniquement si la classe LogService est dans le
										// path
@EnableConfigurationProperties(LogProperties.class) // <-- On va utiliser des propriété perso de la class LogProperties
													// et créeer les beans correspondants
public class LoggerAutoConfiguration {

	@Bean
	@ConditionalOnMissingBean // <-- Crée un bean a condition qu'il n'y ait pas déjà de bean LogService déjà
								// présent dans l'app
	public LogService logService() {
		return new LogServiceImpl();
	}

}
