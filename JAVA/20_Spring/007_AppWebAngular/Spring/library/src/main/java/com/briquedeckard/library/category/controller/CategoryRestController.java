package com.briquedeckard.library.category.controller;

import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.util.CollectionUtils;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.briquedeckard.library.category.Category;
import com.briquedeckard.library.category.dto.CategoryDTO;
import com.briquedeckard.library.category.service.impl.CategoryServiceImpl;

import io.swagger.annotations.ApiOperation;
import io.swagger.v3.oas.annotations.parameters.RequestBody;

@CrossOrigin(origins = "http://localhost:4200")
@RestController
@RequestMapping("/rest/category/api")
public class CategoryRestController {

	@Autowired
	private CategoryServiceImpl categoryService;

	@GetMapping("/allCategories")
	public ResponseEntity<List<CategoryDTO>> getAllBookCategories() {
		List<Category> categories = categoryService.getAllCategories();
		if (!CollectionUtils.isEmpty(categories)) {
			// on retire tous les élts null que peut contenir cette liste
			categories.removeAll(Collections.singleton(null));
			List<CategoryDTO> categoryDTOs = categories.stream().map(category -> {
				return mapCategoryToCategoryDTO(category);
			}).collect(Collectors.toList());
			// Return 200
			return new ResponseEntity<List<CategoryDTO>>(categoryDTOs, HttpStatus.OK);
		}
		return new ResponseEntity<List<CategoryDTO>>(HttpStatus.NO_CONTENT);

	}

	@PostMapping("/addCategory")
	@ApiOperation(value = "Add a new Category in the library", response = CategoryDTO.class)
	public ResponseEntity<CategoryDTO> createNewCategory(@RequestBody CategoryDTO categoryDtoRequest) {
		// If the category already exist, return 409 - CONFLICT
		Category existingCategory = categoryService.findCategoryByLabel(categoryDtoRequest.getLabel());
		if (existingCategory != null) {
			return new ResponseEntity<CategoryDTO>(HttpStatus.CONFLICT);
		}

		// Else, transform the DTO and save the entity
		Category categoryRequest = mapCategoryDtoToCategory(categoryDtoRequest);
		Category categoryResponse = categoryService.saveCategory(categoryRequest);
		// If the category has been created, return 201 - CREATED
		if (categoryResponse != null) {
			CategoryDTO categoryDto = mapCategoryToCategoryDTO(categoryResponse);
			return new ResponseEntity<CategoryDTO>(categoryDto, HttpStatus.CREATED);
		}
		// Else return 304 - Not modified
		return new ResponseEntity<CategoryDTO>(HttpStatus.NOT_MODIFIED);

	}

	private CategoryDTO mapCategoryToCategoryDTO(Category category) {
		ModelMapper mapper = new ModelMapper();
		CategoryDTO categoryDTO = mapper.map(category, CategoryDTO.class);
		return categoryDTO;
	}

	private Category mapCategoryDtoToCategory(CategoryDTO categoryDto) {
		ModelMapper mapper = new ModelMapper();
		Category category = mapper.map(categoryDto, Category.class);
		return category;
	}

}
