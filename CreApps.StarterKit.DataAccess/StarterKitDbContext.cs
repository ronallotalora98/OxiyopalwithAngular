using CreApps.StarterKit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreApps.StarterKit.DataAccess
{
    public class StarterKitDbContext : DbContext
    {
        public StarterKitDbContext(DbContextOptions<StarterKitDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();

            modelBuilder.Entity<TicketType>().HasData(
                new TicketType
                {
                    Id = 1,
                    TicketTypeName = "Problem"
                },
                new TicketType
                {
                    Id = 2,
                    TicketTypeName = "Incident"
                },
                new TicketType
                {
                    Id = 3,
                    TicketTypeName = "New Requirement"
                }
            );

            modelBuilder.Entity<Priority>().HasData(
                new Priority
                {
                    Id = 1,
                    PriorityName = "Critical"
                },
                new Priority
                {
                    Id = 2,
                    PriorityName = "Urgent"
                },
                new Priority
                {
                    Id = 3,
                    PriorityName = "Medium"
                },
                new Priority
                {
                    Id = 4,
                    PriorityName = "Low"
                }
            );

            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    Id = 1,
                    StatusName = "Pending"
                },
                new Status
                {
                    Id = 2,
                    StatusName = "In progress"
                },
                new Status
                {
                    Id = 3,
                    StatusName = "Resolved"
                },
                new Status
                {
                    Id = 4,
                    StatusName = "Closed"
                },
                new Status
                {
                    Id = 5,
                    StatusName = "Discarted"
                }
            );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    Subject = "Create DB",
                    Description = "I need create a bd to save tickets",
                    PriorityId = 1,
                    StatusId = 1,
                    TypeId = 1
                }
                );
            modelBuilder.Entity<Estado>().HasData(
               new Estado
               {
                   Id = 1,
                   NombreEstado = "LLeno"
               },
               new Estado
               {
                   Id = 2,
                   NombreEstado = "Vacio"
               },
               new Estado
               {
                   Id = 3,
                   NombreEstado = "Danañado"
               },
               new Estado
               {
                   Id = 4,
                   NombreEstado = "En Mantenimiento"
               }

            );

            modelBuilder.Entity<Bodega>().HasData(
                new Bodega
                {
                    Id = 1,
                    NombreBodega = "Bodega LLena"
                },
                new Bodega
                {
                    Id = 2,
                    NombreBodega = "Bodega Vacia"
                },
                new Bodega
                {
                    Id = 3,
                    NombreBodega = "Oxifull Bogota"
                }
             );

            modelBuilder.Entity<TipoContenido>().HasData(
                new TipoContenido
                {
                    Id = 1,
                    NombreTipoContenido = "Oxigeno"
                },
                new TipoContenido
                {
                    Id = 2,
                    NombreTipoContenido = "Acetileno"
                },
                new TipoContenido
                {
                    Id = 3,
                    NombreTipoContenido = "Mezcla"
                },
                new TipoContenido
                {
                    Id = 4,
                    NombreTipoContenido = "Nitrogeno"
                },
                new TipoContenido
                {
                    Id = 5,
                    NombreTipoContenido = "Argon"
                },
                new TipoContenido
                {
                    Id = 6,
                    NombreTipoContenido = "Dioxido De Carbono"
                }

             );
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 1,
                    NombreCliente="Ronall Otalora",
                    DireccionCliente="Calle 38a #16-50",
                    TelefonoCliente="3114992296",
                    DocumentoCliente="1118571567"                    
                   
                }
             );

            modelBuilder.Entity<Ubicacion>().HasData(
                new Ubicacion
                {
                    Id = 1,
                    UbicacionCilindro = "Bodega",
                    ClienteId = 1,
                    BodegaId = 1
                },
                new Ubicacion
                {
                    Id = 2,
                    UbicacionCilindro = "Cliente",
                    ClienteId = 1,
                    BodegaId = 1
                }
             );

        }
    }
}
