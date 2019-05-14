import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GlobalSettings } from '../../../base/GlobalSettings';
import { Cliente } from '../../../Models/Cliente'
import { ClienteService } from '../cliente.service';
import { error } from 'protractor';

@Component({
  selector: 'app-list-cliente',
  templateUrl: './list-cliente.component.html',
  styleUrls: ['./list-cliente.component.css']
})
export class ListClienteComponent implements OnInit {

    Clientes: any;
    //clien : Cliente[] = [];
    
    TextoBoton: string = "Actualizar";
    constructor(private clienteService: ClienteService,
        private httpClient: HttpClient) { }
   
   

    ngOnInit() {
        //Opcion 1
        this.clienteService.getClientes().subscribe(result => {
            this.Clientes = result;
            console.log(result);
        }, error => console.error(error));
        
        //this.cargarData();
        //this.clienteService.refreshList();
        
    }

    //Opcion 2
    //actualizarInfo() {
    //    this.httpClient.get(GlobalSettings.ApiURL + 'api/cliente').toPromise().then((res: Cliente[]) => {
    //        if (this.clien.length == 0) {
    //            this.clien = res;
    //        } else {
    //            this.clien.push(...res);
    //        }
    //    });
    //    console.log(this.clien);
    //    this.TextoBoton = "Traer mas datos";
    //}


 
    
}
