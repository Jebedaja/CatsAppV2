﻿// <auto-generated />
using System;
using CatsApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatsApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240203204338_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CatsApp.Models.CatImage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CatsModelEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatsModelEntityId");

                    b.ToTable("CatImage");
                });

            modelBuilder.Entity("CatsApp.Models.CatsModelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("CatsModelEntity");
                });

            modelBuilder.Entity("CatsApp.Models.UserGalleryImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CatImageId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CatsModelEntityId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatImageId");

                    b.HasIndex("CatsModelEntityId");

                    b.ToTable("UserGalleryImage");
                });

            modelBuilder.Entity("CatsApp.Models.CatImage", b =>
                {
                    b.HasOne("CatsApp.Models.CatsModelEntity", null)
                        .WithMany("AllImages")
                        .HasForeignKey("CatsModelEntityId");
                });

            modelBuilder.Entity("CatsApp.Models.UserGalleryImage", b =>
                {
                    b.HasOne("CatsApp.Models.CatImage", "CatImage")
                        .WithMany()
                        .HasForeignKey("CatImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatsApp.Models.CatsModelEntity", null)
                        .WithMany("UserGallery")
                        .HasForeignKey("CatsModelEntityId");

                    b.Navigation("CatImage");
                });

            modelBuilder.Entity("CatsApp.Models.CatsModelEntity", b =>
                {
                    b.Navigation("AllImages");

                    b.Navigation("UserGallery");
                });
#pragma warning restore 612, 618
        }
    }
}