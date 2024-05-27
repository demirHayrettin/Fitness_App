﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectTask.DAL;

#nullable disable

namespace ProjectTask.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240527232149_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectTask.DATA.Besin", b =>
                {
                    b.Property<int>("BesinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BesinId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<int?>("YemekId")
                        .HasColumnType("int");

                    b.HasKey("BesinId");

                    b.HasIndex("YemekId");

                    b.ToTable("Besinler", (string)null);
                });

            modelBuilder.Entity("ProjectTask.DATA.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Boy")
                        .HasColumnType("float");

                    b.Property<string>("Cinsiyet")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Kilo")
                        .HasColumnType("float");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar", (string)null);
                });

            modelBuilder.Entity("ProjectTask.DATA.Ogun", b =>
                {
                    b.Property<int>("OgunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgunId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("OgunId");

                    b.ToTable("Ogunler", (string)null);
                });

            modelBuilder.Entity("ProjectTask.DATA.Porsiyon", b =>
                {
                    b.Property<int>("PorsiyonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PorsiyonId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Miktar")
                        .HasColumnType("float");

                    b.HasKey("PorsiyonId");

                    b.ToTable("Porsiyonlar", (string)null);
                });

            modelBuilder.Entity("ProjectTask.DATA.Yemek", b =>
                {
                    b.Property<int>("YemekId")
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Tarif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YemekId");

                    b.ToTable("Yemekler", (string)null);
                });

            modelBuilder.Entity("ProjectTask.DATA.YemekKategori", b =>
                {
                    b.Property<int>("YemekKategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YemekKategoriId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("YemekKategoriId");

                    b.ToTable("Yemek Kategorileri", (string)null);
                });

            modelBuilder.Entity("ProjectTask.DATA.YemekPlani", b =>
                {
                    b.Property<int>("YemekPlaniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YemekPlaniId"));

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("YemekPlaniId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("YemekPlanlari", (string)null);
                });

            modelBuilder.Entity("ProjectTask.DATA.YemekPlaniOgesi", b =>
                {
                    b.Property<int>("YemekPlaniOgesiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YemekPlaniOgesiId"));

                    b.Property<int>("OgunId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Saat")
                        .HasColumnType("datetime2");

                    b.Property<int>("YemekId")
                        .HasColumnType("int");

                    b.Property<int?>("YemekPlaniId")
                        .HasColumnType("int");

                    b.HasKey("YemekPlaniOgesiId");

                    b.HasIndex("OgunId");

                    b.HasIndex("YemekId");

                    b.HasIndex("YemekPlaniId");

                    b.ToTable("YemekPlaniOgesi", (string)null);
                });

            modelBuilder.Entity("ProjectTask.DATA.Besin", b =>
                {
                    b.HasOne("ProjectTask.DATA.Yemek", null)
                        .WithMany("Besinler")
                        .HasForeignKey("YemekId");
                });

            modelBuilder.Entity("ProjectTask.DATA.Yemek", b =>
                {
                    b.HasOne("ProjectTask.DATA.Porsiyon", "Porsiyon")
                        .WithMany()
                        .HasForeignKey("YemekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectTask.DATA.YemekKategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("YemekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Porsiyon");
                });

            modelBuilder.Entity("ProjectTask.DATA.YemekPlani", b =>
                {
                    b.HasOne("ProjectTask.DATA.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("ProjectTask.DATA.YemekPlaniOgesi", b =>
                {
                    b.HasOne("ProjectTask.DATA.Ogun", "Ogun")
                        .WithMany()
                        .HasForeignKey("OgunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectTask.DATA.Yemek", "Yemek")
                        .WithMany()
                        .HasForeignKey("YemekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectTask.DATA.YemekPlani", null)
                        .WithMany("YemekPlaniOgesi")
                        .HasForeignKey("YemekPlaniId");

                    b.Navigation("Ogun");

                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("ProjectTask.DATA.Yemek", b =>
                {
                    b.Navigation("Besinler");
                });

            modelBuilder.Entity("ProjectTask.DATA.YemekPlani", b =>
                {
                    b.Navigation("YemekPlaniOgesi");
                });
#pragma warning restore 612, 618
        }
    }
}
