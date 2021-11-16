import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { SomeObjectInterface } from './models/SomeObjectInterface';

export const OBJECTS: SomeObjectInterface[] = [
  { id: 2, stringValue: "String 1" },
  { id: 3, stringValue: "String 2" },
  { id: 4, stringValue: "String 3" },
  { id: 5, stringValue: "String 4" },
  { id: 6, stringValue: "String 5" },
]

@Injectable({
  providedIn: 'root'
})
export class ObjectService {
  // Some object to display
  someObject: SomeObjectInterface = {
    id: 1,
    stringValue: "\"Yellow bricks road\""
  };
  constructor() { }



  getSomeObject(): SomeObjectInterface {
    return this.someObject;
  }

  getSomeOnjects(): SomeObjectInterface[] {
    return OBJECTS;

  }

  getSomeObjectsAsync(): Observable<SomeObjectInterface[]> {
    const objects = of(OBJECTS);
    return objects;
  }

  getSomeObjectById(id:number): Observable<SomeObjectInterface>{
    const oneObject = OBJECTS.find( o => o.id === id)!;
    return of(oneObject);
  }
}
