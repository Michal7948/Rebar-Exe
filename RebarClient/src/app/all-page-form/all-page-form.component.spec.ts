import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllPageFormComponent } from './all-page-form.component';

describe('AllPageFormComponent', () => {
  let component: AllPageFormComponent;
  let fixture: ComponentFixture<AllPageFormComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AllPageFormComponent]
    });
    fixture = TestBed.createComponent(AllPageFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
