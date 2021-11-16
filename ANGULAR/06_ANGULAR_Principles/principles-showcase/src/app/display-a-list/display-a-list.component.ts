import { Component, OnInit } from '@angular/core';
import { OBJECTS } from '../object.service';

@Component({
  selector: 'app-display-a-list',
  templateUrl: './display-a-list.component.html',
  styleUrls: ['./display-a-list.component.css']
})
export class DisplayAListComponent implements OnInit {

  constructor() { }

  objects = OBJECTS;

  ngOnInit(): void {
  }

}
