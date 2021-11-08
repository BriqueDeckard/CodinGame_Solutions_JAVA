package com.briquedeckard.library.category.service;

import java.util.List;

import com.briquedeckard.library.category.Category;

public interface CategoryService {
	public List<Category> getAllCategories();

	public Category saveCategory(Category category);

	public Category findCategoryByLabel(String label);

}
