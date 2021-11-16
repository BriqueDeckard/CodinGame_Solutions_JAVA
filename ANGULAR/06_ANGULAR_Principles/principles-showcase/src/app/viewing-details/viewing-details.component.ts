import { Component, OnInit } from '@angular/core';
import { SomeObjectInterface } from '../models/SomeObjectInterface';
import { OBJECTS } from '../object.service';

@Component({
  selector: 'app-viewing-details',
  templateUrl: './viewing-details.component.html',
  styleUrls: ['./viewing-details.component.css']
})
export class ViewingDetailsComponent implements OnInit {

  selectedObject?: SomeObjectInterface;

  constructor() { }

  objects = OBJECTS;

  ngOnInit(): void {
  }

  onSelect(object: SomeObjectInterface): void {
    this.selectedObject = object;
  }

}
