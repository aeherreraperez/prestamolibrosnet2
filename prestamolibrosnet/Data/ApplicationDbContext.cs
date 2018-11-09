using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using prestamolibrosnet.Models;

namespace prestamolibrosnet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<prestamolibrosnet.Models.Categoria> Categoria { get; set; }
        public DbSet<prestamolibrosnet.Models.Usuario> Usuario { get; set; }
        public DbSet<prestamolibrosnet.Models.Libro> Libro { get; set; }
        public DbSet<prestamolibrosnet.Models.Prestamo> Prestamo { get; set; }
        public DbSet<prestamolibrosnet.Models.Calificacion> Calificacion { get; set; }
    
    }
}
