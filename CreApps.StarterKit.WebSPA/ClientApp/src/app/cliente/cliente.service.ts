import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../../Models/Cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

    formdata: Cliente;
    readonly apiURL = 'https://localhost:44373/api'; 
    //readonly apiURL = 'http://localhost:52042/api';
    list: Cliente[];
    
    
    

    constructor(private http: HttpClient) { }

    //metodo 2 para traer datos del api
    //getPersonas(): Observable<Cliente[]> {
    //    return this.http.get<Cliente[]>(this.URL);
    //}

    //Metodo 1 para traer datos del api
    getClientes() {
        
        return this.http.get(this.apiURL + '/cliente');
       
    }
    createCliente(formdata: Cliente) {
        return this.http.post(this.apiURL + '/cliente', formdata);
    }
}
