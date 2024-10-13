﻿// <auto-generated />
using System;
using ApiEmpresa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiEmpresa.Migrations
{
    [DbContext(typeof(Conexiones))]
    [Migration("20241012022327_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiEmpresa.Models.Clientes", b =>
                {
                    b.Property<int>("id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("apellidos")
                        .HasColumnType("longtext");

                    b.Property<string>("direccion")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("fecha_nacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("nit")
                        .HasColumnType("longtext");

                    b.Property<string>("nombres")
                        .HasColumnType("longtext");

                    b.Property<string>("telefono")
                        .HasColumnType("longtext");

                    b.HasKey("id_cliente");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}