﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMvcEst.Data;

namespace SalesWebMvcEst.Migrations
{
    [DbContext(typeof(SalesWebMvcEstContext))]
    [Migration("20200112223417_OtherMigration")]
    partial class OtherMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMvcEst.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SalesWebMvcEst.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("SellersId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellersId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SalesWebMvcEst.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("BaseSalary")
                        .HasColumnType("double");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentsId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesWebMvcEst.Models.SalesRecord", b =>
                {
                    b.HasOne("SalesWebMvcEst.Models.Seller", "Sellers")
                        .WithMany("Sales")
                        .HasForeignKey("SellersId");
                });

            modelBuilder.Entity("SalesWebMvcEst.Models.Seller", b =>
                {
                    b.HasOne("SalesWebMvcEst.Models.Department", "Departments")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentsId");
                });
#pragma warning restore 612, 618
        }
    }
}
