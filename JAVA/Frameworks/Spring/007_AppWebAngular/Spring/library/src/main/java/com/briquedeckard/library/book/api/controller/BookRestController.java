package com.briquedeckard.library.book.api.controller;

import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.util.CollectionUtils;
import org.springframework.web.bind.annotation.CrossOrigin;
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

import com.briquedeckard.library.book.application.services.contracts.BookApplicationService;
import com.briquedeckard.library.book.application.services.contracts.dto.BookDTO;
import com.briquedeckard.library.book.domain.aggregates.Book;
import com.briquedeckard.library.book.domain.repository.BookRepository;
import com.briquedeckard.library.book.domain.services.BookServiceImpl;

import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import io.swagger.annotations.ApiResponse;
import io.swagger.annotations.ApiResponses;

@RestController
@CrossOrigin(origins = "http://localhost:4200")
@RequestMapping("/rest/book/api")
@Api(value = "Book Rest Controller: contains all operations for managing books.")
public class BookRestController {

	public static final Logger LOGGER = LoggerFactory.getLogger(BookRestController.class);

	@Autowired
	private BookServiceImpl bookService;


	@Autowired
	private BookApplicationService bookApplicationService;

	@PostMapping("/addBook")
	@ApiOperation(value = "Add a new Book in the library", response = BookDTO.class)
	@ApiResponses(value = { @ApiResponse(code = 409, message = "Conflict: the book already exist"),
			@ApiResponse(code = 201, message = "Created: the book is successfully inserted"),
			@ApiResponse(code = 304, message = "Not Modified: the book is unsuccessfully inserted") })
	public ResponseEntity<BookDTO> createNewBook(@RequestBody BookDTO bookDTORequest) {

		Book existingBook = bookService.findBookByIsbn(bookDTORequest.getIsbn());
		if (existingBook != null) {
			// return 409
			return new ResponseEntity<BookDTO>(HttpStatus.CONFLICT);
		}

		Book book = bookService.saveBook(bookDTORequest);
		if (book != null && book.getId() != null) {
			BookDTO bookDTO = bookApplicationService.mapBookToBookDTO(book);
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

		Book book = bookService.updateBook(bookDtoRequest);
		if (book != null) {
			BookDTO bookDTO = bookApplicationService.mapBookToBookDTO(book);
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
				return bookApplicationService.mapBookToBookDTO(book);
			}).collect(Collectors.toList());
			// Return 200
			return new ResponseEntity<List<BookDTO>>(bookDTOs, HttpStatus.OK);
		}
		// Return 204
		return new ResponseEntity<List<BookDTO>>(HttpStatus.NO_CONTENT);
	}

	@GetMapping("/getAllBooks")
	public ResponseEntity<List<BookDTO>> getAllBooks() {
		List<Book> books = bookService.getAllBooks();
		if (!CollectionUtils.isEmpty(books)) {
			books.removeAll(Collections.singleton(null));
			List<BookDTO> bookDTOs = books.stream().map(book -> {
				return bookApplicationService.mapBookToBookDTO(book);
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
			BookDTO bookDTO = bookApplicationService.mapBookToBookDTO(book);
			// Return 200
			return new ResponseEntity<BookDTO>(bookDTO, HttpStatus.OK);
		}
		// Return 204
		return new ResponseEntity<BookDTO>(HttpStatus.NO_CONTENT);
	}

}
