import { Component, OnInit } from '@angular/core';
import { SomeObjectInterface } from '../models/SomeObjectInterface';
import { ObjectService } from '../object.service';

@Component({
  selector: 'app-show-an-object',
  templateUrl: './show-an-object.component.html',
  styleUrls: ['./show-an-object.component.css']
})
export class ShowAnObjectComponent implements OnInit {

  someObject: SomeObjectInterface;

  constructor(objectService: ObjectService) {
    this.someObject = objectService.getSomeObject();
  }

  ngOnInit(): void {
  }

}
