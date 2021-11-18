/**
 * 
 */
package com.briquedeckard.library.book.domain.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.briquedeckard.library.book.application.services.contracts.dto.BookDTO;
import com.briquedeckard.library.book.domain.aggregates.Book;
import com.briquedeckard.library.book.domain.repository.BookRepository;
import com.briquedeckard.library.book.domain.services.contracts.BookService;

/**
 * @author pierr
 *
 */
@Service("bookService")
@Transactional
public class BookServiceImpl implements BookService {

	@Autowired
	private BookRepository bookRepository;

	@Override
	public Book saveBook(BookDTO book) {
		return bookRepository.insertABook(book);
	}

	@Override
	public Book updateBook(BookDTO book) {
		return bookRepository.updateABook(book);
	}

	@Override
	public void deleteBook(Integer bookId) {
		bookRepository.remove(bookId);
	}

	@Override
	public List<Book> findBooksByTitleOrPartTitle(String title) {
		return bookRepository.findByTitleLikeIgnoreCase(title);
	}

	@Override
	public Book findBookByIsbn(String isbn) {
		return bookRepository.findByIsbnIgnoreCase(isbn);
	}

	@Override
	public boolean checkIfIdExists(Integer id) {
		return bookRepository.existsById(id);
	}

	@Override
	public List<Book> getBooksByCategory(String codeCategory) {
		return bookRepository.findByCategory(codeCategory);
	}

	@Override
	public List<Book> getAllBooks() {
		return bookRepository.findAll();
	}

}
