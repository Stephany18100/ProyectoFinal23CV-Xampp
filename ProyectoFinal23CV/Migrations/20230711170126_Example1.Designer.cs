﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal23CV.Context;

namespace ProyectoFinal23CV.Migrations
{
    [DbContext(typeof(ApplicationDBContex))]
    [Migration("20230711170126_Example1")]
    partial class Example1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProyectoFinal23CV.Entities.Rol", b =>
                {
                    b.Property<int>("PkRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PkRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProyectoFinal23CV.Entities.Usuario", b =>
                {
                    b.Property<int>("PkUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FKRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PkUsuario");

                    b.HasIndex("FKRol");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoFinal23CV.Entities.Usuario", b =>
                {
                    b.HasOne("ProyectoFinal23CV.Entities.Rol", "Roles")
                        .WithMany()
                        .HasForeignKey("FKRol");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
