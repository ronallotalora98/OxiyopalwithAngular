using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CreApps.StarterKit.Models
{
    public class Bodega: EntityBase<int>
    {
        public string NombreBodega { get; set; }

        public IList<Ubicacion> Ubicacions { get; set; }
    }
}
