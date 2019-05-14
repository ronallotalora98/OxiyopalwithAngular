using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CreApps.StarterKit.Models
{
    public class TipoContenido: EntityBase<int>
    {
        public string NombreTipoContenido { get; set; }
        public IList<Cilindro> Cilindros { get; set; }
    }
}
