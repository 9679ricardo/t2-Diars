using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2.Models;

namespace T2.DB.Configuraciones
{
    public class PeliculaConfiguracion : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.ToTable("Pelicula");
            builder.HasKey(o => o.Id_Pelicula);
        }
    }
}
