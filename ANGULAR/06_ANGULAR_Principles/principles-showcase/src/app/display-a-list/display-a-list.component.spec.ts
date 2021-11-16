import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayAListComponent } from './display-a-list.component';

describe('DisplayAListComponent', () => {
  let component: DisplayAListComponent;
  let fixture: ComponentFixture<DisplayAListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DisplayAListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DisplayAListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
