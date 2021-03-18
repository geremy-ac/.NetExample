﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCORE_CRUD_991.Models.DAL;

namespace NETCORE_CRUD_991.Migrations
{
    [DbContext(typeof(DbContextPrueba))]
    [Migration("20200831191203_Primera")]
    partial class Primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NETCORE_CRUD_991.Models.Entities.CargoEmpleado", b =>
                {
                    b.Property<int>("IdCargo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreCargo")
                        .IsRequired()
                        .HasColumnName("Cargo")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCargo");

                    b.ToTable("CargoEmpleados");
                });

            modelBuilder.Entity("NETCORE_CRUD_991.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreCliente")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCliente");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("NETCORE_CRUD_991.Models.Entities.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cargo")
                        .HasColumnType("int");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreEmpleado")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdEmpleado");

                    b.ToTable("empleados");
                });

            modelBuilder.Entity("NETCORE_CRUD_991.Models.Entities.Paquete", b =>
                {
                    b.Property<int>("IdPaquete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("COL")
                        .HasColumnType("int");

                    b.Property<string>("CodigoPaquete")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoMercancia")
                        .HasColumnType("int");

                    b.Property<int>("IdTransportadora")
                        .HasColumnType("int");

                    b.Property<int>("IdValorLibra")
                        .HasColumnType("int");

                    b.Property<float>("PesoLibra")
                        .HasColumnType("real");

                    b.Property<string>("USA")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("ValorPagar")
                        .HasColumnType("real");

                    b.HasKey("IdPaquete");

                    b.ToTable("paquetes");
                });

            modelBuilder.Entity("NETCORE_CRUD_991.Models.Entities.TipoMercancia", b =>
                {
                    b.Property<int>("IdTipoMercancia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreTipoMercancia")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdTipoMercancia");

                    b.ToTable("tipomercancias");
                });

            modelBuilder.Entity("NETCORE_CRUD_991.Models.Entities.Transportadoras", b =>
                {
                    b.Property<int>("IdTransportadora")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreTransportadora")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdTransportadora");

                    b.ToTable("transportadoras");
                });

            modelBuilder.Entity("NETCORE_CRUD_991.Models.Entities.ValorLibra", b =>
                {
                    b.Property<int>("IdValorLibra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("IdValorLibra");

                    b.ToTable("valorlibra");
                });
#pragma warning restore 612, 618
        }
    }
}
