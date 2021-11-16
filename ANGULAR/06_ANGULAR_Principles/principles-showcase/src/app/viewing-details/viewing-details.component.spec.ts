import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewingDetailsComponent } from './viewing-details.component';

describe('ViewingDetailsComponent', () => {
  let component: ViewingDetailsComponent;
  let fixture: ComponentFixture<ViewingDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewingDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewingDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
