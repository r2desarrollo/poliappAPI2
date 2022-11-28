using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poliappAPI.DTOs
{
    public class PesajeDTO
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public double Pesoneto { get; set; }
        public string Evidencia { get; set; }
        public string Sucursal { get; set; }
        public string Proveedor { get; set; }

    }
}
