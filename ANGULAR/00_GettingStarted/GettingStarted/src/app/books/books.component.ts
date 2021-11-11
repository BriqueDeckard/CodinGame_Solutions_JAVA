import { Component, OnInit } from '@angular/core';
import { Book } from '../models/books';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {

  books: Book[] | undefined;

  constructor(private bookService: BooksService) { }

  ngOnInit(): void {
    this.bookService.getBooks().subscribe(
      (data) => {
        this.books = data;
      }
    )
  }

}
