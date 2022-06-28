﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RevendaVeiculos.Repositorio.Contexto;

namespace RevendaVeiculos.Repositorio.Migrations
{
    [DbContext(typeof(RevendaVeiculosContexto))]
    [Migration("20220624211403_EdicaoBanco")]
    partial class EdicaoBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RevendaVeiculos.Dominio.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Numero");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Servico")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("RevendaVeiculos.Dominio.Entidades.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("RevendaVeiculos.Dominio.Entidades.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Proprietarios");
                });

            modelBuilder.Entity("RevendaVeiculos.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("RevendaVeiculos.Dominio.Entidades.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnoModelo");

                    b.Property<int?>("MarcaId");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("ProprietarioId");

                    b.Property<int>("Quilometragem");

                    b.Property<string>("Renavam")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("RevendaVeiculos.Dominio.Entidades.Proprietario", b =>
                {
                    b.HasOne("RevendaVeiculos.Dominio.Entidades.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("RevendaVeiculos.Dominio.Entidades.Veiculo", b =>
                {
                    b.HasOne("RevendaVeiculos.Dominio.Entidades.Marca", "Marca")
                        .WithMany("Veiculos")
                        .HasForeignKey("MarcaId");

                    b.HasOne("RevendaVeiculos.Dominio.Entidades.Proprietario", "Proprietario")
                        .WithMany("Veiculos")
                        .HasForeignKey("ProprietarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
