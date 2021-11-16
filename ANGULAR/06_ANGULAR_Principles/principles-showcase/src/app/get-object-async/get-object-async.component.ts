import { Component, Input, OnInit } from '@angular/core';
import { SomeObjectInterface } from '../models/SomeObjectInterface';
import { ObjectService } from '../object.service';

@Component({
  selector: 'app-get-object-async',
  templateUrl: './get-object-async.component.html',
  styleUrls: ['./get-object-async.component.css']
})
export class GetObjectAsyncComponent implements OnInit {

  constructor(private objectService: ObjectService) { }

  objects?: SomeObjectInterface[]

  ngOnInit(): void {
    this.getObjects();
  }

  private getObjects(): void {
    this.objectService.getSomeObjectsAsync()
      .subscribe(objects => this.objects = objects);
  }

}
