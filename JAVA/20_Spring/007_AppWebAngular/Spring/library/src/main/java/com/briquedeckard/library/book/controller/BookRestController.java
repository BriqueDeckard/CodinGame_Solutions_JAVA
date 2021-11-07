package com.briquedeckard.library.book.controller;

import java.time.LocalDate;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

import org.modelmapper.ModelMapper;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.util.CollectionUtils;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.util.UriComponentsBuilder;

import com.briquedeckard.library.book.Book;
import com.briquedeckard.library.book.dto.BookDTO;
import com.briquedeckard.library.book.service.impl.BookServiceImpl;
import com.briquedeckard.library.category.Category;
import com.briquedeckard.library.category.dto.CategoryDTO;

@RestController
@RequestMapping("/rest/book/api")
public class BookRestController {

	public static final Logger LOGGER = LoggerFactory.getLogger(BookRestController.class);

	@Autowired
	private BookServiceImpl bookService;

	@PostMapping("/addBook")
	public ResponseEntity<BookDTO> createNewBook(@RequestBody BookDTO bookDTORequest) {
		Book existingBook = bookService.findBookByIsbn(bookDTORequest.getIsbn());
		if (existingBook != null) {
			// return 409
			return new ResponseEntity<BookDTO>(HttpStatus.CONFLICT);
		}

		// Create a request from the DTO
		Book bookRequest = mapBookDTOToBook(bookDTORequest);

		Book book = bookService.saveBook(bookRequest);
		if (book != null && book.getId() != null) {
			BookDTO bookDTO = mapBookToBookDTO(book);
			// Return 201
			return new ResponseEntity<BookDTO>(bookDTO, HttpStatus.CREATED);
		}
		// return 304
		return new ResponseEntity<BookDTO>(HttpStatus.NOT_MODIFIED);
	}

	@PutMapping("/updateBook")
	public ResponseEntity<BookDTO> updateBook(@RequestBody BookDTO bookDtoRequest) {
		if (!bookService.checkIfIdExists(bookDtoRequest.getId())) {
			// Return 404
			return new ResponseEntity<BookDTO>(HttpStatus.NOT_FOUND);
		}

		Book bookRequest = mapBookDTOToBook(bookDtoRequest);
		Book book = bookService.updateBook(bookRequest);
		if (book != null) {
			BookDTO bookDTO = mapBookToBookDTO(book);
			return new ResponseEntity<BookDTO>(bookDTO, HttpStatus.OK);

		}
		// Return 304
		return new ResponseEntity<BookDTO>(HttpStatus.NOT_MODIFIED);
	}

	@DeleteMapping("/deleteBook/{bookId}")
	public ResponseEntity<String> deleteBook(@PathVariable Integer bookId) {
		bookService.deleteBook(bookId);
		// Return 204
		return new ResponseEntity<String>(HttpStatus.NO_CONTENT);
	}

	@GetMapping("/searchByTitle")
	public ResponseEntity<List<BookDTO>> searchBookByTitle(@RequestParam("title") String title,
			UriComponentsBuilder uriComponentsBuilder) {
		List<Book> books = bookService.findBooksByTitleOrPartTitle(title);
		if (!CollectionUtils.isEmpty(books)) {
			books.removeAll(Collections.singleton(null));
			List<BookDTO> bookDTOs = books.stream().map(book -> {
				return mapBookToBookDTO(book);
			}).collect(Collectors.toList());
			// Return 200
			return new ResponseEntity<List<BookDTO>>(bookDTOs, HttpStatus.OK);
		}
		// Return 204
		return new ResponseEntity<List<BookDTO>>(HttpStatus.NO_CONTENT);
	}

	@GetMapping("/searchByIsbn")
	public ResponseEntity<BookDTO> searchBookByIsbn(@RequestParam("isbn") String isbn,
			UriComponentsBuilder uriComponentBuilder) {
		Book book = bookService.findBookByIsbn(isbn);
		if (book != null) {
			BookDTO bookDTO = mapBookToBookDTO(book);
			// Return 200
			return new ResponseEntity<BookDTO>(bookDTO, HttpStatus.OK);
		}
		// Return 204
		return new ResponseEntity<BookDTO>(HttpStatus.NO_CONTENT);
	}

	private BookDTO mapBookToBookDTO(Book book) {
		ModelMapper mapper = new ModelMapper();
		BookDTO bookDTO = mapper.map(book, BookDTO.class);
		if (book.getCategory() != null) {
			bookDTO.setCategory(new CategoryDTO(book.getCategory().getCode(), book.getCategory().getLabel()));
		}
		return bookDTO;
	}

	private Book mapBookDTOToBook(BookDTO bookDTO) {
		ModelMapper mapper = new ModelMapper();
		Book book = mapper.map(bookDTO, Book.class);
		book.setCategory(new Category(bookDTO.getCategory().getCode(), ""));
		book.setRegisterDate(LocalDate.now());
		return book;
	}

}
