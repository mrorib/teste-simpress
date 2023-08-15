﻿// <auto-generated />
using API.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Infra.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230814180547_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Domain.Entities.CategoriaProduto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("ativo")
                        .HasColumnType("bit");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CategoriasProduto");
                });

            modelBuilder.Entity("API.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("ativo")
                        .HasColumnType("bit");

                    b.Property<int>("categoriaProdutoid")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("perecivel")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("categoriaProdutoid");

                    b.ToTable("ProdutosProduto");
                });

            modelBuilder.Entity("API.Domain.Entities.Produto", b =>
                {
                    b.HasOne("API.Domain.Entities.CategoriaProduto", "categoriaProduto")
                        .WithMany()
                        .HasForeignKey("categoriaProdutoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoriaProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
