import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { HeaderSectionComponent } from './header-section/header-section.component';
import { LoginComponent } from './login/login.component';
import { SharedLayoutComponent } from './Shared/shared-layout/shared-layout.component';
import { TicketComponent } from './ticket/ticket.component';
import { MaxFechaComponent } from './max-fecha/max-fecha.component';
import { ListClienteComponent } from './cliente/list-cliente/list-cliente.component';
import { ClienteService } from './cliente/cliente.service';
import { ClienteFormComponent } from './cliente/cliente-form/cliente-form.component';


const routes: Routes =
    [
        {
            path: '', component: SharedLayoutComponent,
            children: [
                //Todas las páginas que necesiten del layout base van aquí
                { path: '', component: HomeComponent },
                { path: 'home', component: HomeComponent },
                { path: 'ticket', component: TicketComponent, pathMatch: 'full' },
                { path: 'cliente', component: ListClienteComponent, pathMatch: 'full' },
                { path: 'cliente-agregar', component: ClienteFormComponent },
                { path: 'cliente-editar/:id', component: ClienteFormComponent }
            ]
        },
        //Todas las páginas que no requieran un layout van aquí
        { path: 'Login', component: LoginComponent }
    ];


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        HeaderSectionComponent,
        LoginComponent,
        SharedLayoutComponent,
        TicketComponent,
        MaxFechaComponent,
        ListClienteComponent,
        ClienteFormComponent
    ],
    imports: [
        BrowserModule,
        RouterModule.forRoot(routes),
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule
    ],
    providers: [ClienteService],
    bootstrap: [AppComponent]
})
export class AppModule { }
