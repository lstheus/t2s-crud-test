﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteBackEnd.Infra.Context;

#nullable disable

namespace TesteBackEnd.Infra.Migrations
{
    [DbContext(typeof(TesteContext))]
    [Migration("20230110191137_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TesteBackEnd.Core.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("TesteBackEnd.Core.Entities.Conteiner", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("ClienteId");

                    b.ToTable("conteiners");
                });

            modelBuilder.Entity("TesteBackEnd.Core.Entities.Movimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoConteiner")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DtFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoMov")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodigoConteiner");

                    b.ToTable("movimentacoes");
                });

            modelBuilder.Entity("TesteBackEnd.Core.Entities.Conteiner", b =>
                {
                    b.HasOne("TesteBackEnd.Core.Entities.Cliente", null)
                        .WithMany("conteiners")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TesteBackEnd.Core.Entities.Movimentacao", b =>
                {
                    b.HasOne("TesteBackEnd.Core.Entities.Conteiner", null)
                        .WithMany("movimentacoes")
                        .HasForeignKey("CodigoConteiner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TesteBackEnd.Core.Entities.Cliente", b =>
                {
                    b.Navigation("conteiners");
                });

            modelBuilder.Entity("TesteBackEnd.Core.Entities.Conteiner", b =>
                {
                    b.Navigation("movimentacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
