﻿// <auto-generated />
using System;
using AppTorresVendas.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppTorresVendas.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231211063319_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppTorresVendas.Models.CategoriaModel", b =>
                {
                    b.Property<long?>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<Guid>("CategoriaIDGUID")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("AppTorresVendas.Models.ClienteModel", b =>
                {
                    b.Property<long?>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<Guid>("ClienteIDGUID")
                        .HasColumnType("char(36)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AppTorresVendas.Models.PedidoModel", b =>
                {
                    b.Property<long?>("PedidoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ClienteModelID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("PedidoIDGUID")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("PedidoID");

                    b.HasIndex("ClienteModelID");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("AppTorresVendas.Models.PedidoProdutoModel", b =>
                {
                    b.Property<long?>("PedidoProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("PedidoModelPedidoID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProdutoID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("PedidoProdutoID");

                    b.HasIndex("PedidoModelPedidoID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("PedidosProdutos");
                });

            modelBuilder.Entity("AppTorresVendas.Models.ProdutoModel", b =>
                {
                    b.Property<long?>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("CategoriaID")
                        .HasColumnType("bigint");

                    b.Property<long>("Estoque")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<Guid>("ProdutoIDGUID")
                        .HasColumnType("char(36)");

                    b.HasKey("ProdutoID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("AppTorresVendas.Models.PedidoModel", b =>
                {
                    b.HasOne("AppTorresVendas.Models.ClienteModel", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("AppTorresVendas.Models.PedidoProdutoModel", b =>
                {
                    b.HasOne("AppTorresVendas.Models.PedidoModel", null)
                        .WithMany("ProdutosPedido")
                        .HasForeignKey("PedidoModelPedidoID");

                    b.HasOne("AppTorresVendas.Models.ProdutoModel", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("AppTorresVendas.Models.ProdutoModel", b =>
                {
                    b.HasOne("AppTorresVendas.Models.CategoriaModel", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("AppTorresVendas.Models.PedidoModel", b =>
                {
                    b.Navigation("ProdutosPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
