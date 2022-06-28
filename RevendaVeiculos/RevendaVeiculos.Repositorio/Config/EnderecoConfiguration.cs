using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevendaVeiculos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Repositorio.Config
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder
                .Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100);
            builder
               .Property(e => e.Estado)
               .IsRequired()
               .HasMaxLength(50);
            builder
               .Property(e => e.Rua)
               .IsRequired()
               .HasMaxLength(100);
            builder
               .Property(e => e.Servico)
               .IsRequired()
               .HasMaxLength(100);
            builder
               .Property(e => e.Numero)
               .IsRequired();
        }
    }
}
