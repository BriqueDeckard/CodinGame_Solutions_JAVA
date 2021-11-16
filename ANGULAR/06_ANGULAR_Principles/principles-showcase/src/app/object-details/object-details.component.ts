import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SomeObjectInterface } from '../models/SomeObjectInterface';
import { ObjectService } from '../object.service';
@Component({
  selector: 'app-object-details',
  templateUrl: './object-details.component.html',
  styleUrls: ['./object-details.component.css']
})
export class ObjectDetailsComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private objectService: ObjectService
  ) { }

  @Input() object?: SomeObjectInterface;

  ngOnInit(): void {
    this.getObject();
  }

  getObject(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.objectService.getSomeObjectById(id).subscribe(object => this.object = object);
  }

}
