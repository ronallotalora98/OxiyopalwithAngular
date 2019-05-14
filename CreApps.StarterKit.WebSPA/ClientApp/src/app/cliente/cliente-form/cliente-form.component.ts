import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Cliente } from '../../../Models/Cliente';
import { ClienteService } from '../cliente.service';
import { error } from 'util';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-cliente-form',
  templateUrl: './cliente-form.component.html',
  styleUrls: ['./cliente-form.component.css']
})
export class ClienteFormComponent implements OnInit {

    constructor(private fb: FormBuilder,
        private clienteService: ClienteService,
        private router: Router,
        private activateRoute: ActivatedRoute) { }

    formGroup: FormGroup;
    modoEdicion: boolean = false;
    clienteid: number;
    

    ngOnInit() {
        //se le asigna a forgrup el tipo de datos que va a cargar
        this.formGroup = this.fb.group({
            nombreCliente: '',
            documentoCliente: '',
            direccionCliente: '',
            telefonoCliente:''
        });
        ///Obtener el id de la ruta para definir si es crear o editar
        this.activateRoute.params.subscribe(params => {
            if (params["id"] == undefined) {
                return;
            }
            this.modoEdicion = true;
            this.clienteid = params["id"];
            //Obtener los datos del cliente en el Id
            this.clienteService.getCliente(this.clienteid.toString())
                .subscribe(cliente => this.cargarcliente(cliente),
                    error => console.error(error));
            
        });
    }
    ///Guardar los datos del cliente
    save() {
        let cliente: Cliente =  this.formGroup.value;
        console.table(cliente);
        if (this.modoEdicion) {
            //Editar el registro
            cliente.Id = this.clienteid;
            this.clienteService.updateCliente(cliente).subscribe(cliente => this.onSaveSuccess(),
                error => console.error(error));
        } else {
            //Agregar el registro
            this.clienteService.createCliente(cliente).subscribe(cliente => this.onSaveSuccess(),
                error => console.error(error));
        }
        
    }
    ///cargar los datos del cliente en el formunlarion
    cargarcliente(cliente: Cliente) {
        this.formGroup.patchValue({
            nombreCliente: cliente.nombreCliente,
            documentoCliente: cliente.documentoCliente,
            direccionCliente: cliente.direccionCliente,
            telefonoCliente: cliente.telefonoCliente
        });
        console.table(cliente);
    }

    //Unabes guerde cambios balla a la vista clientes
    onSaveSuccess() {
        this.router.navigate(["/cliente"])
    }
}
