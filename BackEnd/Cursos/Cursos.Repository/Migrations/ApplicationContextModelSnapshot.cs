﻿// <auto-generated />
using System;
using Cursos.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cursos.Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Cursos.Core.Model.Cartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("BandeiraCartao")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodigoCartao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EhAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EhDeletado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdEstudante")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeTitular")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroCartao")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValidadeCartao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cartoes");
                });

            modelBuilder.Entity("Cursos.Core.Model.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("DuracaoCurso")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EhAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EhDeletado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ValorCurso")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Cursos.Core.Model.Estudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EhAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EhDeletado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Estudantes");
                });

            modelBuilder.Entity("Cursos.Core.Model.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int>("CodigoCurso")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CodigoEstudante")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EhAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EhDeletado")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("Cursos.Core.Model.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EhAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EhDeletado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdCartao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdCurso")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdEstudante")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
