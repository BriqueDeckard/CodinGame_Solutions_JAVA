package com.briquedeckard.library.category.dao;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.briquedeckard.library.category.Category;

@Repository
public interface CategoryDao extends JpaRepository<Category, String> {	

}
