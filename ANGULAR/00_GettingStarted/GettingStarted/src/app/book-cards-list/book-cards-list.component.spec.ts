import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookCardsListComponent } from './book-cards-list.component';

describe('BookCardsListComponent', () => {
  let component: BookCardsListComponent;
  let fixture: ComponentFixture<BookCardsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookCardsListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BookCardsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
