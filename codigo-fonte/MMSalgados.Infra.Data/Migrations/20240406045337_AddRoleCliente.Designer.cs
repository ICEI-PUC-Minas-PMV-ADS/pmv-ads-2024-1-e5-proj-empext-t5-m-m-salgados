﻿// <auto-generated />
using System;
using MMSalgados.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MMSalgados.Infra.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240406045337_AddRoleCliente")]
    partial class AddRoleCliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MMSalgados.Domain.Entities.Acesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int?>("Situacao")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Acesso");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("PedidoId")
                        .HasColumnType("integer");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemPedido");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.MapPerfilUsuariosAcessos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AcessoId")
                        .HasColumnType("integer");

                    b.Property<int?>("PerfilUsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AcessoId");

                    b.HasIndex("PerfilUsuarioId");

                    b.ToTable("MapPerfilUsuariosAcessos");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("QuantidadeItens")
                        .HasColumnType("integer");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric(18,2)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.PerfilUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int?>("Situacao")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PerfilUsuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "ADMIN",
                            Situacao = 1
                        },
                        new
                        {
                            Id = 2,
                            Nome = "CLIENTE",
                            Situacao = 1
                        });
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.ProdutoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Camera")
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Memoria")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric(18,2)");

                    b.Property<string>("Processador")
                        .HasColumnType("text");

                    b.Property<string>("RAM")
                        .HasColumnType("text");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ProdutoEntity");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CpfCnpj")
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int?>("PerfilUsuarioId")
                        .HasColumnType("integer");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int?>("Situacao")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PerfilUsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@devscansados.com",
                            Image = "https://s.gravatar.com/avatar/aleatory?d=mm&s=45",
                            Login = "admin",
                            Nome = "admin",
                            PerfilUsuarioId = 1,
                            Senha = "admin@123",
                            Situacao = 1
                        });
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.ItemPedido", b =>
                {
                    b.HasOne("MMSalgados.Domain.Entities.Pedido", "Pedido")
                        .WithMany("ItemPedido")
                        .HasForeignKey("PedidoId");

                    b.HasOne("MMSalgados.Domain.Entities.ProdutoEntity", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.MapPerfilUsuariosAcessos", b =>
                {
                    b.HasOne("MMSalgados.Domain.Entities.Acesso", "Acesso")
                        .WithMany("MapPerfilUsuariosAcessos")
                        .HasForeignKey("AcessoId");

                    b.HasOne("MMSalgados.Domain.Entities.PerfilUsuario", "PerfilUsuario")
                        .WithMany("MapPerfilUsuariosAcessos")
                        .HasForeignKey("PerfilUsuarioId");

                    b.Navigation("Acesso");

                    b.Navigation("PerfilUsuario");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("MMSalgados.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Pedido")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.ProdutoEntity", b =>
                {
                    b.HasOne("MMSalgados.Domain.Entities.Usuario", "Usuario")
                        .WithMany("ProdutoEntity")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("MMSalgados.Domain.Entities.PerfilUsuario", "PerfilUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfilUsuarioId");

                    b.Navigation("PerfilUsuario");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.Acesso", b =>
                {
                    b.Navigation("MapPerfilUsuariosAcessos");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.Pedido", b =>
                {
                    b.Navigation("ItemPedido");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.PerfilUsuario", b =>
                {
                    b.Navigation("MapPerfilUsuariosAcessos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("MMSalgados.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Pedido");

                    b.Navigation("ProdutoEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
