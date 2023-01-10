import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriarEditarConteinerComponent } from './criar-editar-conteiner.component';

describe('CriarEditarConteinerComponent', () => {
  let component: CriarEditarConteinerComponent;
  let fixture: ComponentFixture<CriarEditarConteinerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CriarEditarConteinerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CriarEditarConteinerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
