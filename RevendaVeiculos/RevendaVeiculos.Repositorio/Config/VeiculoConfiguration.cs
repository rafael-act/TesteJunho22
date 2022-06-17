using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevendaVeiculos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Repositorio.Config
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder
                .HasKey(v => v.Id);
            builder
                .Property(v => v.AnoModelo)
                .IsRequired();
            builder
                .HasOne(p => p.Marca);
            builder
                .Property(v => v.Modelo)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(v => v.Quilometragem)
                .IsRequired();
            builder
                .Property(v => v.Renavam)
                .IsRequired()
                .HasMaxLength(11);
            builder
                .Property(v => v.Valor)
                .IsRequired();
            
        }
    }
}
