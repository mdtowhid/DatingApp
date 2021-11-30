﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reddocoin.Data;

namespace Reddocoin.Migrations
{
    [DbContext(typeof(ReddocoinDbContext))]
    [Migration("20211021194054_FRValuesRename")]
    partial class FRValuesRename
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reddocoin.Models.ReddocoinValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Circulating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Holders")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MarketCaps")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RValues")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ReddocoinValues");
                });
#pragma warning restore 612, 618
        }
    }
}
