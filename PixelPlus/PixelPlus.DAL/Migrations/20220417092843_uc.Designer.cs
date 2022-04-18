﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PixelPlus.DAL;

#nullable disable

namespace PixelPlus.DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220417092843_uc")]
    partial class uc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PixelPlus.ENT.Abone", b =>
                {
                    b.Property<int>("AboneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboneId"), 1L, 1);

                    b.Property<int>("AboneBakiye")
                        .HasColumnType("int");

                    b.Property<string>("AboneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AbonelikDurumu")
                        .HasColumnType("bit");

                    b.Property<int>("Depozito")
                        .HasColumnType("int");

                    b.HasKey("AboneId");

                    b.ToTable("Abone");
                });

            modelBuilder.Entity("PixelPlus.ENT.Fatura", b =>
                {
                    b.Property<int>("FaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaId"), 1L, 1);

                    b.Property<int>("AboneId")
                        .HasColumnType("int");

                    b.Property<bool>("FaturaDurumu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FaturaTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("FaturaTutar")
                        .HasColumnType("int");

                    b.HasKey("FaturaId");

                    b.HasIndex("AboneId");

                    b.ToTable("Fatura");
                });

            modelBuilder.Entity("PixelPlus.ENT.Fatura", b =>
                {
                    b.HasOne("PixelPlus.ENT.Abone", "Abone")
                        .WithMany("Faturas")
                        .HasForeignKey("AboneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abone");
                });

            modelBuilder.Entity("PixelPlus.ENT.Abone", b =>
                {
                    b.Navigation("Faturas");
                });
#pragma warning restore 612, 618
        }
    }
}
