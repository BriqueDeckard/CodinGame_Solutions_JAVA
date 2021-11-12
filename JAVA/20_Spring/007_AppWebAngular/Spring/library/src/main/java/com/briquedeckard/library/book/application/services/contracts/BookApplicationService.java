package com.briquedeckard.library.book.application.services.contracts;

import com.briquedeckard.library.book.application.services.contracts.dto.BookDTO;
import com.briquedeckard.library.book.domain.aggregates.Book;

public interface BookApplicationService {
	Book mapBookDTOToBook(BookDTO bookDTO);
	BookDTO mapBookToBookDTO(Book book) ;
}
