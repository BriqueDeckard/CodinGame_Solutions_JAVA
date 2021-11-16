import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowAnObjectComponent } from './show-an-object.component';

describe('ShowAnObjectComponent', () => {
  let component: ShowAnObjectComponent;
  let fixture: ComponentFixture<ShowAnObjectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowAnObjectComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowAnObjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
