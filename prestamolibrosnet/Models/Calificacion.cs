using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prestamolibrosnet.Models
{
    public class Calificacion
    {
        public int id { get; set; }
        public string OwnerID { get; set; }
        public Usuario usuario { get; set; }
        public int idPrestamo { get; set; }
        public Prestamo prestamo { get; set; }
        public int evaluacion { get; set; }
        public string observacion { get; set; }
    }
}
