﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderApp.Data;

#nullable disable

namespace OrderApp.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20241105113618_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("OrderApp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CargoWeight")
                        .HasColumnType("REAL");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecipientAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RecipientCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}