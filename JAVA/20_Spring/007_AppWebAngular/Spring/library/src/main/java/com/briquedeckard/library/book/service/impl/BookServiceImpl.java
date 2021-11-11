/**
 * 
 */
package com.briquedeckard.library.book.service.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.briquedeckard.library.book.Book;
import com.briquedeckard.library.book.dao.BookDao;
import com.briquedeckard.library.book.service.BookService;

/**
 * @author pierr
 *
 */
@Service("bookService")
@Transactional
public class BookServiceImpl implements BookService {

	@Autowired
	private BookDao bookDao;

	@Override
	public Book saveBook(Book book) {
		return bookDao.save(book);
	}

	@Override
	public Book updateBook(Book book) {
		return bookDao.save(book);
	}

	@Override
	public void deleteBook(Integer bookId) {
		bookDao.deleteById(bookId);
	}

	@Override
	public List<Book> findBooksByTitleOrPartTitle(String title) {
		return bookDao.findByTitleLikeIgnoreCase(title);
	}

	@Override
	public Book findBookByIsbn(String isbn) {
		return bookDao.findByIsbnIgnoreCase(isbn);
	}

	@Override
	public boolean checkIfIdExists(Integer id) {
		return bookDao.existsById(id);
	}

	@Override
	public List<Book> getBooksByCategory(String codeCategory) {
		return bookDao.findByCategory(codeCategory);
	}

	@Override
	public List<Book> getAllBooks() {
		return bookDao.findAll();
	}

}
