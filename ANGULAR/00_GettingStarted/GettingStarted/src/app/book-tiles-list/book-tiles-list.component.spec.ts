import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookTilesListComponent } from './book-tiles-list.component';

describe('BookTilesListComponent', () => {
  let component: BookTilesListComponent;
  let fixture: ComponentFixture<BookTilesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookTilesListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BookTilesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
