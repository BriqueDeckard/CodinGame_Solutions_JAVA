package com.briquedeckard.library.category.service.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.briquedeckard.library.category.Category;
import com.briquedeckard.library.category.dao.CategoryDao;
import com.briquedeckard.library.category.service.CategoryService;

@Service("categoryService")
public class CategoryServiceImpl implements CategoryService {

	@Autowired
	private CategoryDao categoryDao;

	@Override
	public List<Category> getAllCategories() {
		return categoryDao.findAll();
	}

	@Override
	public Category saveCategory(Category category) {
		return categoryDao.save(category);
	}

	@Override
	public Category findCategoryByLabel(String label) {
		return categoryDao.findByLabelLikeIgnoreCase(label);
	}

}
