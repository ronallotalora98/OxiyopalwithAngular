using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CreApps.StarterKit.Models
{
    public class Ubicacion :EntityBase<int>
    {
        public string UbicacionCilindro { get; set; }
      
        public int BodegaId { get; set; }
        public Bodega Bodega { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public IList<Cilindro> Cilindros { get; set; }
    }
}
