﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_Evaluation.Web.Data;

namespace Test_Evaluation.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210203024841_AddFiled_2")]
    partial class AddFiled_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test_Evaluation.Common.Entities.EntityCargo", b =>
                {
                    b.Property<int>("Cargo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Cargo");

                    b.ToTable("EntityCargos");
                });

            modelBuilder.Entity("Test_Evaluation.Common.Entities.EntityDepartamento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Codigo");

                    b.ToTable("EntityDepartamentos");
                });

            modelBuilder.Entity("Test_Evaluation.Common.Entities.EntityUsuario", b =>
                {
                    b.Property<int>("Usuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<int?>("Cargo1");

                    b.Property<string>("Cedula");

                    b.Property<int?>("DepartamentoCodigo");

                    b.Property<string>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.HasKey("Usuario");

                    b.HasIndex("Cargo1");

                    b.HasIndex("DepartamentoCodigo");

                    b.ToTable("EntityUsuarios");
                });

            modelBuilder.Entity("Test_Evaluation.Common.Entities.EntityUsuario", b =>
                {
                    b.HasOne("Test_Evaluation.Common.Entities.EntityCargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("Cargo1");

                    b.HasOne("Test_Evaluation.Common.Entities.EntityDepartamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoCodigo");
                });
#pragma warning restore 612, 618
        }
    }
}
