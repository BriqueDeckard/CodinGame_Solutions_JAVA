import { Component, Input, OnInit } from '@angular/core';
import { Book } from '../models/books';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-book-tiles-list',
  templateUrl: './book-tiles-list.component.html',
  styleUrls: ['./book-tiles-list.component.css']
})
export class BookTilesListComponent implements OnInit {

  constructor() { }
  @Input()
  books: Book[] | undefined;

  ngOnInit(): void {
  }

}
