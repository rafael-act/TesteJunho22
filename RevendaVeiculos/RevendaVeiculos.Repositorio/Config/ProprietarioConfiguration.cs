using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevendaVeiculos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Repositorio.Config
{
    public class ProprietarioConfiguration : IEntityTypeConfiguration<Proprietario>
    {
        public void Configure(EntityTypeBuilder<Proprietario> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.Documento)
                .IsRequired()
                .HasMaxLength(20);
            builder
                .Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Status);
            builder
                .HasOne(p => p.Endereco);
            builder
                .HasMany(p => p.Veiculos)
                .WithOne(p => p.Proprietario);
        }
    }
}
