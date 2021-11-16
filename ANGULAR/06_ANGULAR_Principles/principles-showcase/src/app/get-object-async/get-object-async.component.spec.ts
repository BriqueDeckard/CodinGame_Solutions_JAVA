import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetObjectAsyncComponent } from './get-object-async.component';

describe('GetObjectAsyncComponent', () => {
  let component: GetObjectAsyncComponent;
  let fixture: ComponentFixture<GetObjectAsyncComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetObjectAsyncComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetObjectAsyncComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
