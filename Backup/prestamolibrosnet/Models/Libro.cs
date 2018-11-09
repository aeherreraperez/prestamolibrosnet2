using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prestamolibrosnet.Models
{
    public class Libro
    {
        public int id { get; set; }
        public String isbn { get; set; }
        public String titulo { get; set; }
        public String autor { get; set; }
        public DateTime fecha { get; set; }
        public String editorial { get; set; }
        public Categoria categoria { get; set; }
        public Usuario dueno { get; set; }
        public bool prestado { get; set; }
    }
}
