using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CreApps.StarterKit.Models
{ 
    public class Estado: EntityBase<int>
    {
        public string NombreEstado { get; set; }
      

         public IList<Cilindro> Cilindros { get; set; }
    }
}
