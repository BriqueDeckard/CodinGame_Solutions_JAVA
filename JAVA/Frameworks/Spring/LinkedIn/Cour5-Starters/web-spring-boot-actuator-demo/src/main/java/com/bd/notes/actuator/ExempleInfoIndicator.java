package com.bd.notes.actuator;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.boot.actuate.info.Info.Builder;
import org.springframework.boot.actuate.info.InfoContributor;
import org.springframework.boot.context.properties.ConfigurationProperties;
import org.springframework.stereotype.Component;

@Component
public class ExempleInfoIndicator implements InfoContributor {

	@Value("${info.app.name}")
	String appName;

	@Value("${info.app.version}")
	String appVersion;

	@Override
	public void contribute(Builder builder) {
		builder//
				.withDetail("VERSION", appVersion)//
				.withDetail("NAME", appName);

	}

}
