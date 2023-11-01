import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddShakeComponent } from './add-shake.component';

describe('AddShakeComponent', () => {
  let component: AddShakeComponent;
  let fixture: ComponentFixture<AddShakeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddShakeComponent]
    });
    fixture = TestBed.createComponent(AddShakeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
