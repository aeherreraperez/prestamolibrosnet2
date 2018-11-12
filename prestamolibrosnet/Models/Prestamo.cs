using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prestamolibrosnet.Models
{
    public class Prestamo
    {
        public int id { get; set; }
        public int idLibro { get; set; }
        public Libro libro { get; set; }
        public string OwnerID { get; set; }
        public DateTime fechaRealizado { get; set; }
        public DateTime fechaDevolucion { get; set; }
    }
}
