using Escuela.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela.DAL.Context
{
    public class EscuelaDbContext : DbContext
    {
        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Salon> Salones { get; set; }


        public EscuelaDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
