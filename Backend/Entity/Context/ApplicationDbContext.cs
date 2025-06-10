using Entity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
            :base(options)
        {
            _configuration = configuration;
        }

        //Dbset requeridos para la migracion
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }

        //schemes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estudiante>().ToTable("Estudiante", schema: "Colegio");
            modelBuilder.Entity<Curso>().ToTable("Curso", schema: "Colegio");
            modelBuilder.Entity<Matricula>().ToTable("Matricula", schema: "Colegio");
        }
    }
}
