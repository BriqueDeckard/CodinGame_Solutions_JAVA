import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditAnObjectComponent } from './edit-an-object.component';

describe('EditAnObjectComponent', () => {
  let component: EditAnObjectComponent;
  let fixture: ComponentFixture<EditAnObjectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditAnObjectComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditAnObjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
