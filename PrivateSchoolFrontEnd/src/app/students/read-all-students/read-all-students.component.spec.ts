import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadAllStudentsComponent } from './read-all-students.component';

describe('ReadAllStudentsComponent', () => {
  let component: ReadAllStudentsComponent;
  let fixture: ComponentFixture<ReadAllStudentsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReadAllStudentsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReadAllStudentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
