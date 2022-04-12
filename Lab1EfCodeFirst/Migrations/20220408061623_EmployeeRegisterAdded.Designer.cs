﻿// <auto-generated />
using System;
using Lab1EfCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab1EfCodeFirst.Migrations
{
    [DbContext(typeof(EmployeeRegister))]
    [Migration("20220408061623_EmployeeRegisterAdded")]
    partial class EmployeeRegisterAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab1EfCodeFirst.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employess");
                });

            modelBuilder.Entity("Lab1EfCodeFirst.Models.LeaveForm", b =>
                {
                    b.Property<int>("LeaveFormID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfLeave")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRegister")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeaveFormID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("LeaveForms");
                });

            modelBuilder.Entity("Lab1EfCodeFirst.Models.LeaveForm", b =>
                {
                    b.HasOne("Lab1EfCodeFirst.Models.Employee", "Employee")
                        .WithMany("LeaveForms")
                        .HasForeignKey("EmployeeID");
                });
#pragma warning restore 612, 618
        }
    }
}