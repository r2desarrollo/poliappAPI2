using System;
using System.Collections.Generic;

namespace poliappAPI.Models
{
    public partial class Pesaje
    {
        public Pesaje()
        {
        }

        public int Id { get; set; }
        public string Material { get; set; }
        public double Pesoneto { get; set; }
        public string Evidencia { get; set; }
        public string Sucursal { get; set; }
        public string Proveedor { get; set; }

    }
}
