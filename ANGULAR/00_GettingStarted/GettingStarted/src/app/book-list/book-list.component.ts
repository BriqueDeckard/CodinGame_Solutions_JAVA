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


  colors = ['#4b3832', '#854442', '#be9b7b', '#3c2f2f']

  books: Book[] = [];

  option:Book|undefined;

  dataHasChanged(book:Book){
    console.log("Book: " + book)
  }

  constructor(private bookService: BooksService) { }


  ngOnInit(): void {
    this.subscribeToBooks();
  }

  optionChangedHandler(option: string) {
    // Log ! 
    console.log("Option changed");
    var filteredBooks = this.books.filter((x) => x.title?.toLowerCase().includes(option.toLowerCase()));
    filteredBooks.forEach((x) => {
      console.log("Book: " + x);
    });

  }

  private subscribeToBooks() {
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
          element.cols = 1;
          element.rows = 2;

        });
        console.log("data: " + data.length);
        this.books = data;
      }
    );
  }
}
