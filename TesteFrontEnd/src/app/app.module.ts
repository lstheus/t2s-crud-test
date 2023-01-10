import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RelatorioComponent } from './components/relatorio/relatorio.component';
import { ClientesComponent } from './components/clientes/clientes.component';
import { ConteinerComponent } from './components/conteiner/conteiner.component';
import { MovimentacoesComponent } from './components/movimentacoes/movimentacoes.component';
import { CriarClienteComponent } from './components/criar-cliente/criar-cliente.component';
import { CriarEditarConteinerComponent } from './components/criar-editar-conteiner/criar-editar-conteiner.component';
import { CriarEditarMovimentacoesComponent } from './components/criar-editar-movimentacoes/criar-editar-movimentacoes.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CategoryPipe } from './shared/pipes/category.pipe';
import { StatusPipe } from './shared/pipes/status.pipe';
import { TypePipe } from './shared/pipes/type.pipe';
import { MovementPipe } from './shared/pipes/movement.pipe';
@NgModule({
  declarations: [
    AppComponent,
    CategoryPipe,
    RelatorioComponent,
    ClientesComponent,
    ConteinerComponent,
    MovimentacoesComponent,
    CriarClienteComponent,
    CriarEditarConteinerComponent,
    CriarEditarMovimentacoesComponent,
    StatusPipe,
    TypePipe,
    MovementPipe,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,


  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
