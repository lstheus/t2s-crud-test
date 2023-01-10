import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './components/clientes/clientes.component';
import { ConteinerComponent } from './components/conteiner/conteiner.component';
import { CriarClienteComponent } from './components/criar-cliente/criar-cliente.component';
import { CriarEditarConteinerComponent } from './components/criar-editar-conteiner/criar-editar-conteiner.component';
import { CriarEditarMovimentacoesComponent } from './components/criar-editar-movimentacoes/criar-editar-movimentacoes.component';
import { MovimentacoesComponent } from './components/movimentacoes/movimentacoes.component';
import { RelatorioComponent } from './components/relatorio/relatorio.component';

const routes: Routes = [


  { path: '', component: RelatorioComponent },
  { path: 'relatorio', component: RelatorioComponent },
  { path: 'clientes', component: ClientesComponent },
  { path: 'conteiner', component: ConteinerComponent },
  { path: 'movimentacoes', component: MovimentacoesComponent },
  { path: 'criarcliente', component: CriarClienteComponent },
  { path: 'criareditarconteiner', component: CriarEditarConteinerComponent },
  { path: 'criareditarconteiner/:code', component: CriarEditarConteinerComponent },
  { path: 'criareditarmovimentacao', component: CriarEditarMovimentacoesComponent },
   { path: 'criareditarmovimentacao/:id', component: CriarEditarMovimentacoesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
