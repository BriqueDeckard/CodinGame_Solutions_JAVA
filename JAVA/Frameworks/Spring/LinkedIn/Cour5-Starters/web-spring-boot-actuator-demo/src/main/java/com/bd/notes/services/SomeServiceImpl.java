package com.bd.notes.services;

import java.util.Arrays;
import java.util.List;

import org.springframework.stereotype.Service;

@Service
public class SomeServiceImpl {
	List<String> entities = Arrays.asList(new String[] { "Un", "Deux", "Trois" });

	public List<String> getEntities() {
		return entities;
	}

	public void setEntities(List<String> entities) {
		this.entities = entities;
	}

}
