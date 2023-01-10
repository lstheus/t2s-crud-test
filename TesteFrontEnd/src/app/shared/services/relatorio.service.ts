import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { relatorio } from '../models/relatorio';

@Injectable({
  providedIn: 'root'
})
export class RelatorioService {
urlBase = `${environment.UrlMain}Relatorio`
  constructor(private http : HttpClient) { }

  get(): Observable<relatorio>{
    return this.http.get<relatorio>(`${this.urlBase}`);
  }
}
