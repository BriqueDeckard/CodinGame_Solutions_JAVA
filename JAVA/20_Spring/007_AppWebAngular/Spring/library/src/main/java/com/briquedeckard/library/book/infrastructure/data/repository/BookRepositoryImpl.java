package com.briquedeckard.library.book.infrastructure.data.repository;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.briquedeckard.library.book.application.services.contracts.BookApplicationService;
import com.briquedeckard.library.book.application.services.contracts.dto.BookDTO;
import com.briquedeckard.library.book.domain.aggregates.Book;
import com.briquedeckard.library.book.domain.repository.BookRepository;
import com.briquedeckard.library.book.infrastructure.data.dao.BookDao;

@Repository
@Transactional
public class BookRepositoryImpl implements BookRepository {

	@Autowired
	private BookDao bookDao;

	@Autowired
	private BookApplicationService bookApplicationService;

	public void dodid() {

	}

	@Override
	public Book insertABook(BookDTO dto) {
		try {
			return bookDao.save(bookApplicationService.mapBookDTOToBook(dto));
		} catch (Exception e) {
			throw e;
		}

	}

	@Override
	public Book updateABook(BookDTO dto) {
		try {
			return bookDao.save(bookApplicationService.mapBookDTOToBook(dto));
		} catch (Exception e) {
			throw e;
		}
	}

	@Override
	public void remove(Integer bookId) {
		try {
			bookDao.deleteById(bookId);
		} catch (Exception e) {
			throw e;
		}

	}

	@Override
	public List<Book> findByTitleLikeIgnoreCase(String title) {
		try {
			return bookDao.findByTitleLikeIgnoreCase(title);
		} catch (Exception e) {
			throw e;
		}
	}

	@Override
	public Book findByIsbnIgnoreCase(String isbn) {
		try {
			return bookDao.findByIsbnIgnoreCase(isbn);
		} catch (Exception e) {
			throw e;
		}
	}

	@Override
	public boolean existsById(Integer id) {
		try {
			return bookDao.existsById(id);
		} catch (Exception e) {
			throw e;
		}
	}

	@Override
	public List<Book> findByCategory(String codeCategory) {
		try {
			return bookDao.findByCategory(codeCategory);
		} catch (Exception e) {
			throw e;
		}
	}

	@Override
	public List<Book> findAll() {
		try {
			return bookDao.findAll();
		} catch (Exception e) {
			throw e;
		}
	}

}
