import { Component, OnInit } from '@angular/core';
import { count } from 'rxjs';
import { Book } from '../models/books';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  exempleBooks: Book[] = [
    { id: 10, title: 'Brume', cols: 1, rows: 2, color: '#4b3832', isbn: "AAB", releaseDate: new Date(), registerDate: new Date(), totalExamplaries: 10, author: "Stephen King", category: { code: "10", label: "10" } },
    { id: 10, title: 'La tour sombre', cols: 2, rows: 2, color: '#854442', isbn: "AAB", releaseDate: new Date(), registerDate: new Date(), totalExamplaries: 10, author: "Stephen King", category: { code: "10", label: "10" } },
    { id: 10, title: 'Slurp', cols: 1, rows: 4, color: '#be9b7b', isbn: "AAB", releaseDate: new Date(), registerDate: new Date(), totalExamplaries: 10, author: "Stephen King", category: { code: "10", label: "10" } },
    { id: 10, title: 'Harry Potter', cols: 1, rows: 2, color: '#3c2f2f', isbn: "AAB", releaseDate: new Date(), registerDate: new Date(), totalExamplaries: 10, author: "Stephen King", category: { code: "10", label: "10" } },
    { id: 10, title: 'Eragon', cols: 1, rows: 2, color: '#be9b7b', isbn: "AAB", releaseDate: new Date(), registerDate: new Date(), totalExamplaries: 10, author: "Stephen King", category: { code: "10", label: "10" } },
    { id: 1, title: 'Maleville', cols: 1, rows: 1, color: '#4b3832', isbn: "AAB", releaseDate: new Date(), registerDate: new Date(), totalExamplaries: 10, author: "Stephen King", category: { code: "10", label: "10" } },
    { id: 1, title: 'La horde', cols: 1, rows: 1, color: '#854442', isbn: "AAB", releaseDate: new Date(), registerDate: new Date(), totalExamplaries: 10, author: "Stephen King", category: { code: "10", label: "10" } },
  ]

  colors = ['#4b3832', '#854442', '#be9b7b', '#3c2f2f']

  books: Book[] | undefined;

  constructor(private bookService: BooksService) { }


  ngOnInit(): void {

    this.bookService.getBooks().subscribe(
      (data) => {
        var countH = 8;
        var countW = 8;
        data.forEach(element => {
          if (countH <= 0) {
            countH = 8;
          }
          if (countW <= 0) {
            countW = 8;
          }

          var h = Math.floor(Math.random() * countH);
          var w = Math.floor(Math.random() * countW);

          countW = countW - w;
          countH = countH - h;

          element.color = this.colors[Math.floor(Math.random() * this.colors.length)];
          element.cols = h;
          element.rows = w;

        });

        this.books = data;
        this.exempleBooks = data;
      }
    );
  }

}
