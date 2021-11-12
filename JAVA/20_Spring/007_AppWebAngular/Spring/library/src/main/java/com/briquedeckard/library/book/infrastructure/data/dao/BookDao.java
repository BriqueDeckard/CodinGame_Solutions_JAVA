package com.briquedeckard.library.book.infrastructure.data.dao;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.briquedeckard.library.book.domain.aggregates.Book;

@Repository
public interface BookDao extends JpaRepository<Book, Integer> {

	/**
	 * Find a book by its ISBN. Ignore case.
	 * 
	 * @param isbn
	 * @return
	 */
	public Book findByIsbnIgnoreCase(String isbn);

	/**
	 * Find a book by its title. Ignore case.
	 * 
	 * @param titleString
	 * @return
	 */
	public List<Book> findByTitleLikeIgnoreCase(String titleString);

	@Query("SELECT b " //
			+ "FROM Book b " //
			+ "INNER JOIN b.category cat " //
			+ "WHERE cat.code = :code")
	public List<Book> findByCategory(@Param("code") String codeCategory);

}
