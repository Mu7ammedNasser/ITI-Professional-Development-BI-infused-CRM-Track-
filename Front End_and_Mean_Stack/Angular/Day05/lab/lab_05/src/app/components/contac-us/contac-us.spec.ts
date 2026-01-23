import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContacUs } from './contac-us';

describe('ContacUs', () => {
  let component: ContacUs;
  let fixture: ComponentFixture<ContacUs>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ContacUs]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ContacUs);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
