import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UploadFormComponent } from './upload.component';

describe('UploadComponent', () => {
  let component: UploadFormComponent;
  let fixture: ComponentFixture<UploadFormComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UploadFormComponent]
    });
    fixture = TestBed.createComponent(UploadFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
