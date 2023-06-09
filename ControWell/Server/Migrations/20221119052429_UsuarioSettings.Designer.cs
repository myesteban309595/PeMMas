﻿// <auto-generated />
using ControWell.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControWell.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221119052429_UsuarioSettings")]
    partial class UsuarioSettings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ControWell.Shared.AforoTK", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<int>("TanqueId")
                        .HasColumnType("int");

                    b.Property<int>("TempBase")
                        .HasColumnType("int");

                    b.Property<int>("Volunen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TanqueId");

                    b.ToTable("AforoTKs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Material = "acero",
                            Nivel = 100,
                            TanqueId = 2,
                            TempBase = 120,
                            Volunen = 1000
                        });
                });

            modelBuilder.Entity("ControWell.Shared.Pozo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombrePozo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operadora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pozos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comentario = "Pozo en produccion",
                            NombrePozo = "CH-245 B",
                            Operadora = "Ecopetrol",
                            Ubicacion = "Chichimene"
                        },
                        new
                        {
                            Id = 2,
                            Comentario = "Pozo en suspendido",
                            NombrePozo = "CH-215 A2",
                            Operadora = "Halliburton",
                            Ubicacion = "Chichimene"
                        },
                        new
                        {
                            Id = 3,
                            Comentario = "Pozo en pruebas extensas",
                            NombrePozo = "CH-98",
                            Operadora = "Ecopetrol",
                            Ubicacion = "Chichimene"
                        });
                });

            modelBuilder.Entity("ControWell.Shared.Tanque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Capacidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreTanque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoFluido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tanques");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacidad = "1000",
                            NombreTanque = "TK-915 NF",
                            TipoFluido = "Nafta"
                        },
                        new
                        {
                            Id = 2,
                            Capacidad = "2000",
                            NombreTanque = "TK-98 OL",
                            TipoFluido = "Petroleo"
                        },
                        new
                        {
                            Id = 3,
                            Capacidad = "1000",
                            NombreTanque = "TK-103 WT",
                            TipoFluido = "Agua"
                        });
                });

            modelBuilder.Entity("ControWell.Shared.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoAcceso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Sanchez",
                            Cargo = "Inpector de medicion",
                            Cedula = 1002,
                            Nombre = "Dagoberto",
                            TipoAcceso = 1
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Rojas",
                            Cargo = "Gefe de personal",
                            Cedula = 1245,
                            Nombre = "Angelo",
                            TipoAcceso = 2
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Morales",
                            Cargo = "Lider de medicion",
                            Cedula = 850014,
                            Nombre = "Fabian",
                            TipoAcceso = 3
                        });
                });

            modelBuilder.Entity("ControWell.Shared.AforoTK", b =>
                {
                    b.HasOne("ControWell.Shared.Tanque", "Tanque")
                        .WithMany()
                        .HasForeignKey("TanqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tanque");
                });
#pragma warning restore 612, 618
        }
    }
}
