using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prestamolibrosnet.Models
{
    public class Calificacion
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }
        public Prestamo prestamo { get; set; }
        [Range(1,5)]
        public int evaluacion { get; set; }
        public string observacion { get; set; }
    }
}
