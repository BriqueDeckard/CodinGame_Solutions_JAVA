package com.bd.notes.actuator;

import org.springframework.boot.actuate.health.Health;
import org.springframework.boot.actuate.health.HealthIndicator;
import org.springframework.stereotype.Component;

@Component
public class ExempleHealthIndicator implements HealthIndicator {

	@Override
	public Health health() {
		return Health//
				.up()//
				.withDetail("DB", "OK")//
				.withDetail("Network", "OK")//
				.build();
	}

}
