import { Component, OnInit } from '@angular/core';
import { MatBottomSheet, MatBottomSheetRef } from '@angular/material/bottom-sheet';

@Component({
  selector: 'app-bottom-sheet-example',
  templateUrl: './bottom-sheet-example.component.html',
  styleUrls: ['./bottom-sheet-example.component.css']
})
export class BottomSheetExampleComponent implements OnInit {

  exempleCode = `<button mat-raised-button (click)="openBottomSheet()">Open file</button>`;
  typeScriptCode = `
  constructor(private _bottomSheet: MatBottomSheet) { }
  
  openBottomSheet(): void {
    this._bottomSheet.open(BottomSheetExampleSheet);
  }
`
  constructor(private _bottomSheet: MatBottomSheet) { }

  openBottomSheet(): void {
    this._bottomSheet.open(BottomSheetExampleSheet);
  }

  ngOnInit(): void {
  }
}



@Component({
  selector: 'app-bottom-sheet-example-sheet',
  templateUrl: 'bottom-sheet-example-sheet.html',
})
export class BottomSheetExampleSheet {
  constructor(private _bottomSheetRef: MatBottomSheetRef<BottomSheetExampleSheet>) { }

  openLink(event: MouseEvent): void {
    this._bottomSheetRef.dismiss();
    event.preventDefault();
  }
}
