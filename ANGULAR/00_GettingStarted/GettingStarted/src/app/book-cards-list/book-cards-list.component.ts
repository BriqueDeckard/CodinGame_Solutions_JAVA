import { Component, Input, OnInit } from '@angular/core';
import { Book } from '../models/books';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-book-cards-list',
  templateUrl: './book-cards-list.component.html',
  styleUrls: ['./book-cards-list.component.css']
})
export class BookCardsListComponent implements OnInit {

  constructor() { }

  @Input()
  books: Book[] | undefined;

  colors = ['#4b3832', '#854442', '#be9b7b', '#3c2f2f']

  ngOnInit(): void {
  }
}
