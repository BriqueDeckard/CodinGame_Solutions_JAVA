package com.bd.notes;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

import com.bd.notes.service.LogService;

@Component
public class Console implements CommandLineRunner{
	
	@Autowired
	private LogService logService;

	@Override
	public void run(String... args) throws Exception {
		logService.tracer("Hello ! ");
		
	}

}
