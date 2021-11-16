import { Component, Input, OnInit, Output, EventEmitter, OnChanges, SimpleChange, SimpleChanges } from '@angular/core';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs'
import { Book } from '../models/books';
import { map, startWith } from 'rxjs/operators';
import { BooksService } from '../services/books.service';
import { ValueConverter } from '@angular/compiler/src/render3/view/template';


@Component({
  selector: 'app-search-book',
  templateUrl: './search-book.component.html',
  styleUrls: ['./search-book.component.css']
})
export class SearchBookComponent implements OnInit {

  @Input()
  books: Book[] = [];


  change(){
    console.log("Change ! ");
  }

  constructor() { }


  ngOnChanges(changes: SimpleChanges) {
  }

  ngOnInit(): void {   
    
  }



}
