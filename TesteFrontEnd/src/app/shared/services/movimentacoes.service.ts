import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { movimentacoes } from '../models/movimentacoes';

@Injectable({
  providedIn: 'root'
})
export class MovimentacoesService {
  urlBase = `${environment.UrlMain}Movimentacao` 
  constructor(private http: HttpClient) { }

  get():Observable<movimentacoes[]>{
    return this.http.get<movimentacoes[]>(`${this.urlBase}`);
  }
  post(movimentacao : movimentacoes){
   return this.http.post(`${this.urlBase}`,movimentacao);
  }
  getById(id: number){
    return  this.http.get(`${this.urlBase}/GetById/${id}`);
  }
    put(id: number, movimentacao: movimentacoes ) {
    return this.http.put(`${this.urlBase}/Put/${id}`, movimentacao);
  }
  delete(id: number) {
    return this.http.delete(`${this.urlBase}/Delete/${id}`);
  }
}
