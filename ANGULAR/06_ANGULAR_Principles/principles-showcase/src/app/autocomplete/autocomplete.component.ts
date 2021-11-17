import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';



@Component({
  selector: 'app-autocomplete',
  templateUrl: './autocomplete.component.html',
  styleUrls: ['./autocomplete.component.css']
})
export class AutocompleteComponent implements OnInit {
  myControl = new FormControl();
  options: string[] = ['One', 'Two', 'Three'];
  filteredOptions: Observable<string[]> | undefined;
  codeStart = "{{";
  codeEnd = "}}";

  exempleCode = `<form class="example-form"\><mat-label>Number: </mat-label>\n`
    + `<mat-form-field class="example-full-width" appearance="fill">\n`
    + `<input type=\"text\" placeholder=\"Pick one\" aria-label=\"Number\" matInput [formControl]=\"myControl\"\n`
    + `[matAutocomplete]=\"auto\">\n`
    + "<mat-autocomplete autoActiveFirstOption #auto=\"matAutocomplete\"> \n"
    + "<mat-option *ngFor=\"let option of filteredOptions | async\" [value]=\"option\">\n"
    + "{{option}}\n"
    + "</mat-option>\n"
    + "</mat-autocomplete>\n"
    + "</mat-form-field>\n"
    + "</form>\n";


  ngOnInit(): void {
    // Filters options asynchronously
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      map(value => this._filter(value)),
    );
  }

  constructor() { }

  private _filter(value: string): string[] {
    const filterValue = value.toLowerCase();
    return this.options.filter(option => option.toLowerCase().includes(filterValue));
  }

}
