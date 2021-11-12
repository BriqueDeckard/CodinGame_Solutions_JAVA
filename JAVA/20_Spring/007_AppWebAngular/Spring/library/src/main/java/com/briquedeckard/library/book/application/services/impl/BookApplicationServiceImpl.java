package com.briquedeckard.library.book.application.services.impl;

import java.time.LocalDate;

import org.modelmapper.ModelMapper;

import com.briquedeckard.library.book.application.services.contracts.BookApplicationService;
import com.briquedeckard.library.book.application.services.contracts.dto.BookDTO;
import com.briquedeckard.library.book.domain.aggregates.Book;
import com.briquedeckard.library.category.Category;
import com.briquedeckard.library.category.dto.CategoryDTO;

public class BookApplicationServiceImpl implements BookApplicationService {

	@Override
	public Book mapBookDTOToBook(BookDTO bookDTO) {
		ModelMapper mapper = new ModelMapper();
		Book book = mapper.map(bookDTO, Book.class);
		book.setCategory(new Category(bookDTO.getCategory().getCode(), ""));
		book.setRegisterDate(LocalDate.now());
		return book;
	}

	@Override
	public BookDTO mapBookToBookDTO(Book book) {
		ModelMapper mapper = new ModelMapper();
		BookDTO bookDTO = mapper.map(book, BookDTO.class);
		if (book.getCategory() != null) {
			bookDTO.setCategory(new CategoryDTO(book.getCategory().getCode(), book.getCategory().getLabel()));
		}
		return bookDTO;
	}
}
