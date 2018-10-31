using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prestamolibrosnet.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public String email { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String password { get; set; }
        public String direccion { get; set; }
    }
}
