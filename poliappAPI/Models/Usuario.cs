using System;
using System.Collections.Generic;

namespace poliappAPI.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sucursal { get; set; }
        public byte Nivel { get; set; }
        public string Foto { get; set; }
        public byte Prol { get; set; }
    }
}
