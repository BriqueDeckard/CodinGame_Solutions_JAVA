package com.bd.notes.infrastructure.actuator;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.actuate.info.Info.Builder;
import org.springframework.boot.actuate.info.InfoContributor;

import com.bd.notes.infrastructure.data.repository.UserRepository;

public class TotalUserInfo implements InfoContributor {

	private final UserRepository repository;

	@Autowired
	public TotalUserInfo(UserRepository repository) {
		this.repository = repository;
	}

	@Override
	public void contribute(Builder builder) {
		builder.withDetail("users", repository.count());
	}

}
