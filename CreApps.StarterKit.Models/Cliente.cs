using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CreApps.StarterKit.Models
{
     public class Cliente: EntityBase<int>
    {
        public string NombreCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }

        
        public IList<Ubicacion> Ubicacions { get; set; }

    }
}
