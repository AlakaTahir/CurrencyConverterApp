﻿// <auto-generated />
using System;
using Converter.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Converter.Migrations.Migrations
{
    [DbContext(typeof(ConverterInformationDataBaseContext))]
    [Migration("20230113175910_create-date-update")]
    partial class createdateupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Converter.Model.Entity.CurrencyInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CurrencySymbol")
                        .HasColumnType("varchar(1) CHARACTER SET utf8mb4")
                        .HasMaxLength(1);

                    b.Property<double>("ToDollarRate")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("CurrencyInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
