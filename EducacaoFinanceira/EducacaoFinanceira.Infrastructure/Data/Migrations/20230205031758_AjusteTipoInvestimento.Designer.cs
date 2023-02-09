﻿// <auto-generated />
using System;
using EducacaoFinanceira.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EducacaoFinanceira.Infrastructure.Data.Migrations
{
    [DbContext(typeof(EducacaoFinanceiraDbContext))]
    [Migration("20230205031758_AjusteTipoInvestimento")]
    partial class AjusteTipoInvestimento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EducacaoFinanceira.Domain.Entities.ModeloIr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ModeloIr");
                });

            modelBuilder.Entity("EducacaoFinanceira.Domain.Entities.ModeloIrOcorrencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModeloIrId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModeloIrId");

                    b.ToTable("ModeloIrOcorrencia");
                });

            modelBuilder.Entity("EducacaoFinanceira.Domain.Entities.TipoInvestimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModeloIrId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModeloIrId");

                    b.ToTable("TipoInvestimento");
                });

            modelBuilder.Entity("EducacaoFinanceira.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EducacaoFinanceira.Domain.Entities.ModeloIrOcorrencia", b =>
                {
                    b.HasOne("EducacaoFinanceira.Domain.Entities.ModeloIr", "ModeloIr")
                        .WithMany()
                        .HasForeignKey("ModeloIrId");

                    b.Navigation("ModeloIr");
                });

            modelBuilder.Entity("EducacaoFinanceira.Domain.Entities.TipoInvestimento", b =>
                {
                    b.HasOne("EducacaoFinanceira.Domain.Entities.ModeloIr", "ModeloIr")
                        .WithMany()
                        .HasForeignKey("ModeloIrId");

                    b.Navigation("ModeloIr");
                });
#pragma warning restore 612, 618
        }
    }
}
