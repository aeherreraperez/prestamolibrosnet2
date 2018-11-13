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
        public int fecha { get; set; }
        public String editorial { get; set; }
        public String estado { get; set; }
        public Categoria categoria { get; set; }
        public string OwnerID { get; set; }
        public bool prestado { get; set; }
    }
}
