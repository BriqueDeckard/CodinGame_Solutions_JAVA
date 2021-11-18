package com.briquedeckard.library.book.domain.repository;

import java.util.List;

import com.briquedeckard.library.book.application.services.contracts.dto.BookDTO;
import com.briquedeckard.library.book.domain.aggregates.Book;

public interface BookRepository {

	Book insertABook(BookDTO dto);

	Book updateABook(BookDTO dto);

	void remove(Integer bookId);

	List<Book> findByTitleLikeIgnoreCase(String title);

	Book findByIsbnIgnoreCase(String isbn);

	boolean existsById(Integer id);

	List<Book> findByCategory(String codeCategory);

	List<Book> findAll();
	
	
	
	

}
