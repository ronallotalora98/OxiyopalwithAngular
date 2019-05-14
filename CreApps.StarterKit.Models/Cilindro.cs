using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CreApps.StarterKit.Models
{
    public class Cilindro: EntityBase<int>
    {
   
        public string Serial { get; set; }
        public decimal Tamaño { get; set; }
        public DateTime FechaDeTraslado { get; set; }
        public DateTime FechaHoy { get; set; } 
        public string MostrarUbicacion { get; set; }
        

        //public DateTime TiempoDeTraslado { get; set; }

        public int TipoContenidoId { get; set; }
        public TipoContenido TipoContenido { get; set; }

        public int EstadoId { get; set; }
        public Estado Estado { get; set; }


        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set; }

    }
}
