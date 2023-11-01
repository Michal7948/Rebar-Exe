import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddShakeOrderComponent } from './add-shake-order.component';

describe('AddShakeOrderComponent', () => {
  let component: AddShakeOrderComponent;
  let fixture: ComponentFixture<AddShakeOrderComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddShakeOrderComponent]
    });
    fixture = TestBed.createComponent(AddShakeOrderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
