﻿// <auto-generated />
using System;
using EfCodeFirstFluentApi.Models.Manager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCodeFirstFluentApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190512014033_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfCodeFirstFluentApi.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerId")
                        .HasMaxLength(5);

                    b.Property<string>("City")
                        .HasColumnName("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnName("CompanyName")
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasColumnName("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasColumnName("Country")
                        .HasMaxLength(15);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = "a1",
                            City = "Ankara",
                            CompanyName = "A",
                            ContactName = "burak parlak",
                            Country = "Turkey"
                        },
                        new
                        {
                            CustomerId = "a2",
                            City = "Ankara",
                            CompanyName = "B",
                            ContactName = "burak parlak",
                            Country = "Turkey"
                        },
                        new
                        {
                            CustomerId = "a3",
                            City = "Ankara",
                            CompanyName = "C",
                            ContactName = "burak parlak",
                            Country = "Turkey"
                        },
                        new
                        {
                            CustomerId = "a4",
                            City = "Ankara",
                            CompanyName = "D",
                            ContactName = "burak parlak",
                            Country = "Turkey"
                        });
                });

            modelBuilder.Entity("EfCodeFirstFluentApi.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("CustomerId")
                        .HasMaxLength(5);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnName("OrderDate");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = "a1",
                            OrderDate = new DateTime(2019, 5, 12, 4, 40, 32, 951, DateTimeKind.Local).AddTicks(8)
                        });
                });

            modelBuilder.Entity("EfCodeFirstFluentApi.Order", b =>
                {
                    b.HasOne("EfCodeFirstFluentApi.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
