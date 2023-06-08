﻿// <auto-generated />
using FilmeApiCodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebApiFilmeDatabaseFirstExemplo.Migrations
{
    [DbContext(typeof(FilmeContext))]
    partial class FilmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiFilmeDatabaseFirstExemplo.Models.Diretores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Diretores");
                });

            modelBuilder.Entity("WebApiFilmeDatabaseFirstExemplo.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmeId"));

                    b.Property<string>("Diretor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<string>("FilmeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmeId");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("WebApiFilmeDatabaseFirstExemplo.Models.FilmeDiretores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdDiretor")
                        .HasColumnType("int");

                    b.Property<int>("IdFilme")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDiretor");

                    b.HasIndex("IdFilme");

                    b.ToTable("FilmeDiretores");
                });

            modelBuilder.Entity("WebApiFilmeDatabaseFirstExemplo.Models.FilmeDiretores", b =>
                {
                    b.HasOne("WebApiFilmeDatabaseFirstExemplo.Models.Diretores", "Diretores")
                        .WithMany()
                        .HasForeignKey("IdDiretor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiFilmeDatabaseFirstExemplo.Models.Filme", "Filme")
                        .WithMany("FilmeDiretores")
                        .HasForeignKey("IdFilme")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diretores");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("WebApiFilmeDatabaseFirstExemplo.Models.Filme", b =>
                {
                    b.Navigation("FilmeDiretores");
                });
#pragma warning restore 612, 618
        }
    }
}
