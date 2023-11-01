import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessageCreateOrderComponent } from './message-create-order.component';

describe('MessageCreateOrderComponent', () => {
  let component: MessageCreateOrderComponent;
  let fixture: ComponentFixture<MessageCreateOrderComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MessageCreateOrderComponent]
    });
    fixture = TestBed.createComponent(MessageCreateOrderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
