import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from '../models/books';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(
    private http: HttpClient
  ) { }

  getBooks() {
    return this.http.get<Book[]>('http://localhost:8080/rest/book/api/getAllBooks');
  }
}
