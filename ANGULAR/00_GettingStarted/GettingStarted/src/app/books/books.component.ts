import { Component, Input, OnInit } from '@angular/core';
import { Book } from '../models/books';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {

  @Input() book!: Book;

  ngOnInit(): void { }

}
