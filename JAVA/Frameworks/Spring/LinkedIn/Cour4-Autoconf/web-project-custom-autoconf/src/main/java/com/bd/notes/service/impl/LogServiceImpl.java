package com.bd.notes.service.impl;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.bd.notes.service.LogService;
import com.bd.notes.service.properties.LogProperties;

@Service
public class LogServiceImpl implements LogService {

	Logger logger = LoggerFactory.getLogger(LogServiceImpl.class);

	@Autowired
	private LogProperties properties;

	@Override
	public void tracer(String message) {
		logger.info(this.properties.getPrefix() + "Trace affichée dans LogServiceImpl : " + message + " - "
				+ this.properties.getSuffix());

	}

}
