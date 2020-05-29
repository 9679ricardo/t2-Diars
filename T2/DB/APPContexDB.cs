using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2.DB.Configuraciones;
using T2.Models;

namespace T2.DB
{
    public class APPContexDB:DbContext
    {
        public DbSet<Pelicula>Peliculas { get; set; }
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=T2;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // coddigo tabla tabla
            modelBuilder.ApplyConfiguration(new PeliculaConfiguracion());
            
        }

    }
}
