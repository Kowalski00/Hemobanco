﻿// <auto-generated />
using System;
using Hemobanco.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hemobanco.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hemobanco.Models.Doacao", b =>
                {
                    b.Property<int>("DoacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoadorId")
                        .HasColumnType("int");

                    b.Property<double>("QtdSangue")
                        .HasColumnType("float");

                    b.Property<DateTime>("RealizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SangueId")
                        .HasColumnType("int");

                    b.HasKey("DoacaoId");

                    b.HasIndex("DoadorId");

                    b.HasIndex("SangueId");

                    b.ToTable("Doacoes");
                });

            modelBuilder.Entity("Hemobanco.Models.Doador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doadores");
                });

            modelBuilder.Entity("Hemobanco.Models.Estoque", b =>
                {
                    b.Property<int>("EstoqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArmazenadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuncId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("SangueId")
                        .HasColumnType("int");

                    b.HasKey("EstoqueId");

                    b.HasIndex("FuncId");

                    b.HasIndex("SangueId");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Hemobanco.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Hemobanco.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuncId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("SangueId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservaId");

                    b.HasIndex("FuncId");

                    b.HasIndex("SangueId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Hemobanco.Models.Sangue", b =>
                {
                    b.Property<int>("SangueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SangueTipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SangueId");

                    b.ToTable("Sangues");
                });

            modelBuilder.Entity("Hemobanco.Models.Doacao", b =>
                {
                    b.HasOne("Hemobanco.Models.Doador", "Doador")
                        .WithMany()
                        .HasForeignKey("DoadorId");

                    b.HasOne("Hemobanco.Models.Sangue", "Sangue")
                        .WithMany()
                        .HasForeignKey("SangueId");
                });

            modelBuilder.Entity("Hemobanco.Models.Estoque", b =>
                {
                    b.HasOne("Hemobanco.Models.Funcionario", "Func")
                        .WithMany()
                        .HasForeignKey("FuncId");

                    b.HasOne("Hemobanco.Models.Sangue", "sangue")
                        .WithMany()
                        .HasForeignKey("SangueId");
                });

            modelBuilder.Entity("Hemobanco.Models.Reserva", b =>
                {
                    b.HasOne("Hemobanco.Models.Funcionario", "Func")
                        .WithMany()
                        .HasForeignKey("FuncId");

                    b.HasOne("Hemobanco.Models.Sangue", "sangue")
                        .WithMany()
                        .HasForeignKey("SangueId");
                });
#pragma warning restore 612, 618
        }
    }
}
