import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriarEditarMovimentacoesComponent } from './criar-editar-movimentacoes.component';

describe('CriarEditarMovimentacoesComponent', () => {
  let component: CriarEditarMovimentacoesComponent;
  let fixture: ComponentFixture<CriarEditarMovimentacoesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CriarEditarMovimentacoesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CriarEditarMovimentacoesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
