import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MaxFechaComponent } from './max-fecha.component';

describe('MaxFechaComponent', () => {
  let component: MaxFechaComponent;
  let fixture: ComponentFixture<MaxFechaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MaxFechaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MaxFechaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
