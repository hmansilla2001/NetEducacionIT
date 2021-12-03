using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreApellido { get; set; }
        public string Domicilio { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Mail { get; set; }
    }
}
