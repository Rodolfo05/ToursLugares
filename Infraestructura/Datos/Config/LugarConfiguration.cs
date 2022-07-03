using Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos.Config
{
    public class LugarConfiguration : IEntityTypeConfiguration<Lugar>
    {
        public void Configure(EntityTypeBuilder<Lugar> builder)
        {
            builder.Property(l => l.Id).IsRequired();
            builder.Property(l => l.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(l => l.Descripcion).IsRequired();
            builder.Property(l => l.GastoAproximado).IsRequired();

            /*Relaciones*/
            builder.HasOne(c => c.Categoria).WithMany()
                .HasForeignKey(l => l.IdCategoria); //uno a muchos

            builder.HasOne(p => p.Pais).WithMany()
                .HasForeignKey(l => l.IdPais);
        }
    }
}
