import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Cliente } from '../../../Models/Cliente';
import { ClienteService } from '../cliente.service';
import { error } from 'util';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cliente-form',
  templateUrl: './cliente-form.component.html',
  styleUrls: ['./cliente-form.component.css']
})
export class ClienteFormComponent implements OnInit {

    constructor(private fb: FormBuilder,
        private clienteService: ClienteService,
        private router: Router) { }

    formGroup: FormGroup;

    ngOnInit() {
        this.formGroup = this.fb.group({
            nombreCliente: '',
            documentoCliente: '',
            direccionCliente: '',
            telefonoCliente:''
        });
    }

    save() {
        let cliente: Cliente = Object.assign({}, this.formGroup.value);
        console.table(cliente);

        this.clienteService.createCliente(cliente).subscribe(cliente => this.onSaveSuccess(),
            error => console.error(error));
    }
    onSaveSuccess() {
        this.router.navigate(["/cliente"])
    }
}
