import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultaMatriculasComponent } from './consulta-matriculas.component';

describe('ConsultaMatriculasComponent', () => {
  let component: ConsultaMatriculasComponent;
  let fixture: ComponentFixture<ConsultaMatriculasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConsultaMatriculasComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultaMatriculasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
