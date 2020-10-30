﻿// <auto-generated />
using System;
using Leilao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Leilao.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201030175350_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Leilao.Models.PessoaModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IDADE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("Leilao.Models.ProdutoModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ULTIMAPESSOAID")
                        .HasColumnType("int");

                    b.Property<double>("ULTIMOLANCE")
                        .HasColumnType("float");

                    b.Property<double>("VALOR")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("ULTIMAPESSOAID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Leilao.Models.ProdutoModel", b =>
                {
                    b.HasOne("Leilao.Models.PessoaModel", "ULTIMAPESSOA")
                        .WithMany("produtos")
                        .HasForeignKey("ULTIMAPESSOAID");
                });
#pragma warning restore 612, 618
        }
    }
}
