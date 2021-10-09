﻿// <auto-generated />
using System;
using MascotaFeliz.app.persistencia.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotaFeliz.app.persistencia.Migrations
{
    [DbContext(typeof(EfAppContext))]
    [Migration("20211009130436_Inicial2")]
    partial class Inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotaFeliz.app.dominio.Empresa", b =>
                {
                    b.Property<int>("Nit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Nit")
                        .UseIdentityColumn();

                    b.Property<int>("Direccion")
                        .HasColumnType("int")
                        .HasColumnName("Direccion");

                    b.Property<int?>("IdMedico")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Telefono");

                    b.HasKey("Nit");

                    b.HasIndex("IdMedico");

                    b.ToTable("EmpresaDb");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.Mascota", b =>
                {
                    b.Property<int>("IdMascota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdMascota")
                        .UseIdentityColumn();

                    b.Property<string>("ColorOjos")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ColorOjos");

                    b.Property<string>("ColorPiel")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ColorPiel");

                    b.Property<int>("Estatura")
                        .HasColumnType("int")
                        .HasColumnName("Estatura");

                    b.Property<int>("FrecuenciaCardiaca")
                        .HasColumnType("int")
                        .HasColumnName("FrecuenciaCardiaca");

                    b.Property<int>("FrecuenciaRespiratoria")
                        .HasColumnType("int")
                        .HasColumnName("FrecuenciaRespiratoria");

                    b.Property<int?>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<int>("Peso")
                        .HasColumnType("int")
                        .HasColumnName("Peso");

                    b.HasKey("IdMascota");

                    b.HasIndex("IdPropietario");

                    b.ToTable("MascotaDb");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.Medicos", b =>
                {
                    b.Property<int>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdMedico")
                        .UseIdentityColumn();

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Especialidad");

                    b.Property<int?>("IdAnimal")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<int>("TarjetaProfecional")
                        .HasColumnType("int")
                        .HasColumnName("TarjetaProfecional");

                    b.HasKey("IdMedico");

                    b.HasIndex("IdAnimal");

                    b.ToTable("MedicosDb");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Apellido");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Telefono");

                    b.HasKey("Id");

                    b.ToTable("PersonaDb");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.Propietario", b =>
                {
                    b.Property<int>("IdPropietario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPropietario")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Direccion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Telefono");

                    b.HasKey("IdPropietario");

                    b.ToTable("PropietarioDb");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.RegistroAtencion", b =>
                {
                    b.Property<int>("IdAnimal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAnimal")
                        .UseIdentityColumn();

                    b.Property<int?>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("IdAnimal");

                    b.HasIndex("IdPropietario");

                    b.ToTable("RegistroAtencionDb");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.SolicitudAtencion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("NombreMascota")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NombreMascota");

                    b.HasKey("Id");

                    b.ToTable("SolicitudAtencion");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.TipoAnimal", b =>
                {
                    b.Property<int>("IdAnimal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAnimal")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre");

                    b.HasKey("IdAnimal");

                    b.ToTable("TipoAnimal");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.Empresa", b =>
                {
                    b.HasOne("MascotaFeliz.app.dominio.Medicos", "Medicos")
                        .WithMany()
                        .HasForeignKey("IdMedico");

                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.Mascota", b =>
                {
                    b.HasOne("MascotaFeliz.app.dominio.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("IdPropietario");

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.Medicos", b =>
                {
                    b.HasOne("MascotaFeliz.app.dominio.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdAnimal");

                    b.Navigation("TipoAnimal");
                });

            modelBuilder.Entity("MascotaFeliz.app.dominio.RegistroAtencion", b =>
                {
                    b.HasOne("MascotaFeliz.app.dominio.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("IdPropietario");

                    b.Navigation("Propietario");
                });
#pragma warning restore 612, 618
        }
    }
}
