﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trabajos.Data;

#nullable disable

namespace Trabajos.Migrations
{
    [DbContext(typeof(MuebleriaDBContext))]
    partial class MuebleriaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Trabajos.Data.Compras", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int?>("CantidadC")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaC")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreC")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PrecioC")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Trabajos.Data.Empleados", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"));

                    b.Property<string>("ApellidoE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("FechaContratacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PuestoE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Salario")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("IdEmpleado");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Trabajos.Data.Ventas", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"));

                    b.Property<int?>("CantidadV")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("ComprasId")
                        .HasColumnType("int");

                    b.Property<int>("EmpleadosId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaV")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("IdVenta");

                    b.HasIndex("ComprasId");

                    b.HasIndex("EmpleadosId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Trabajos.Data.Ventas", b =>
                {
                    b.HasOne("Trabajos.Data.Compras", "Compras")
                        .WithMany()
                        .HasForeignKey("ComprasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trabajos.Data.Empleados", "Empleados")
                        .WithMany()
                        .HasForeignKey("EmpleadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compras");

                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
