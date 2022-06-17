using Microsoft.EntityFrameworkCore;
using RevendaVeiculos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Repositorio.Config
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(m => m.Id);
            builder
                .Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(m => m.Status);
        }
    }
}
