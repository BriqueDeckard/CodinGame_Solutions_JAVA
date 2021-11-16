import { Component, OnInit } from '@angular/core';
import { SomeObjectInterface } from '../models/SomeObjectInterface';
import { ObjectService } from '../object.service';

@Component({
  selector: 'app-edit-an-object',
  templateUrl: './edit-an-object.component.html',
  styleUrls: ['./edit-an-object.component.css']
})
export class EditAnObjectComponent implements OnInit {

  someObject: SomeObjectInterface;

  constructor(objectService: ObjectService) {
    this.someObject = objectService.getSomeObject();
  }
  ngOnInit(): void {
  }

}
