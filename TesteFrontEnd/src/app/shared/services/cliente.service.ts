import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { map, Observable } from 'rxjs';
import { cliente } from '../models/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  constructor(private http: HttpClient) { 

  }
  urlBase = `${environment.UrlMain}Cliente`;

  get():Observable<cliente[]>{
    return this.http.get<cliente[]>(`${this.urlBase}`);
  }
  post(cliente :cliente){
    return this.http.post(`${this.urlBase}`,cliente);
  }
}
