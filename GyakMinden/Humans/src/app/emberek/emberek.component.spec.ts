import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmberekComponent } from './emberek.component';

describe('EmberekComponent', () => {
  let component: EmberekComponent;
  let fixture: ComponentFixture<EmberekComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EmberekComponent]
    });
    fixture = TestBed.createComponent(EmberekComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
