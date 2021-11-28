package com.bd.notes.domain.service.impl;

import org.springframework.stereotype.Service;

import com.bd.notes.domain.service.UserDomainService;

@Service
public class UserDomainServiceImpl implements UserDomainService {

	@Override
	public String domainOperation() {
		return "42";
	}

}
