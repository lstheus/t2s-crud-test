import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { first } from 'rxjs';
import { movimentacoes } from 'src/app/shared/models/movimentacoes';
import { relatorio } from 'src/app/shared/models/relatorio';
import { RelatorioService } from 'src/app/shared/services/relatorio.service';

@Component({
  selector: 'app-relatorio',
  templateUrl: './relatorio.component.html',
  styleUrls: ['./relatorio.component.css'],
  template: `{{Totalmov}}`
})
export class RelatorioComponent {
  TotalMov!: number;
  TotalImportation!: number;
  TotalExportation!: number;
  TotalCont!: number;
  movimentacoes!: movimentacoes[];
  constructor(private relatorioService: RelatorioService) {
  }
  ngOnInit() {
    this.relatorioService.get().pipe(first()).subscribe({
      next: (success) => {
        this.movimentacoes = success.movimentacoes;
        this.TotalMov = success.totalMov;
        this.TotalExportation = success.totalExportacao;
        this.TotalImportation = success.totalImportacao;
        this.TotalCont = success.totalConteiner;
        console.log(success)
      }
      , error: (err) => {
        console.log(err);
      }
    })
  }

}
