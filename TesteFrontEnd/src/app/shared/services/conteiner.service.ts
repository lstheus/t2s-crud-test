import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { map, Observable } from 'rxjs';
import { conteiner } from '../models/conteiner';

@Injectable({
  providedIn: 'root'
})
export class ConteinerService {
  urlBase = `${environment.UrlMain}Conteiner`;

  constructor(private http: HttpClient) { }

  get(): Observable<conteiner[]> {
    return this.http.get<conteiner[]>(`${this.urlBase}`);
  }
  getById(id : string){
      return this.http.get(`${this.urlBase}/GetByCode/${id}`);
  }
  post(conteiner: conteiner) {
    return this.http.post(`${this.urlBase}`, conteiner);
  }
  put(id: string, conteiner: conteiner) {
    return this.http.put(`${this.urlBase}/Put/${id}`, conteiner);
  }
  delete(id: string) {
    return this.http.delete(`${this.urlBase}/Delete/${id}`);
  }
}
