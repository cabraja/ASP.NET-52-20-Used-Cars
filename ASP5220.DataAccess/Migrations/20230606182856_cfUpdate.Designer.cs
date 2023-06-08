﻿// <auto-generated />
using System;
using ASP5220.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP5220.DataAccess.Migrations
{
    [DbContext(typeof(ASPContext))]
    [Migration("20230606182856_cfUpdate")]
    partial class cfUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP5220.Domain.Entities.AuditLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAuthorized")
                        .HasColumnType("bit");

                    b.Property<string>("UseCaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("EngineCapacity")
                        .HasColumnType("int");

                    b.Property<int?>("MakeId")
                        .HasColumnType("int");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Variant")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.CarUser", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CarId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CarFollowers");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.RoleUseCase", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UseCaseId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "UseCaseId");

                    b.ToTable("RoleUseCases");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.SpecificationCar", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.Property<int>("SpecificationValueId")
                        .HasColumnType("int");

                    b.HasKey("CarId", "SpecificationId", "SpecificationValueId");

                    b.HasIndex("SpecificationId");

                    b.HasIndex("SpecificationValueId");

                    b.ToTable("SpecificationCar");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.SpecificationValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("SpecificationId");

                    b.ToTable("SpecificationValues");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Car", b =>
                {
                    b.HasOne("ASP5220.Domain.Entities.Make", "Make")
                        .WithMany("Cars")
                        .HasForeignKey("MakeId");

                    b.HasOne("ASP5220.Domain.Entities.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId");

                    b.Navigation("Make");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.CarUser", b =>
                {
                    b.HasOne("ASP5220.Domain.Entities.User", "User")
                        .WithMany("FollowedCars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ASP5220.Domain.Entities.Car", "Car")
                        .WithMany("Followers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.File", b =>
                {
                    b.HasOne("ASP5220.Domain.Entities.Car", "Car")
                        .WithMany("Files")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Car");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.RoleUseCase", b =>
                {
                    b.HasOne("ASP5220.Domain.Entities.Role", "Role")
                        .WithMany("RoleUseCases")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.SpecificationCar", b =>
                {
                    b.HasOne("ASP5220.Domain.Entities.Car", "Car")
                        .WithMany("Specifications")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP5220.Domain.Entities.Specification", "Specification")
                        .WithMany("SpecificationCars")
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ASP5220.Domain.Entities.SpecificationValue", "SpecificationValue")
                        .WithMany("SpecificationCars")
                        .HasForeignKey("SpecificationValueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Specification");

                    b.Navigation("SpecificationValue");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.SpecificationValue", b =>
                {
                    b.HasOne("ASP5220.Domain.Entities.Specification", "Specification")
                        .WithMany("SpecificationValues")
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specification");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.User", b =>
                {
                    b.HasOne("ASP5220.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Car", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("Followers");

                    b.Navigation("Specifications");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Make", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Role", b =>
                {
                    b.Navigation("RoleUseCases");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.Specification", b =>
                {
                    b.Navigation("SpecificationCars");

                    b.Navigation("SpecificationValues");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.SpecificationValue", b =>
                {
                    b.Navigation("SpecificationCars");
                });

            modelBuilder.Entity("ASP5220.Domain.Entities.User", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("FollowedCars");
                });
#pragma warning restore 612, 618
        }
    }
}
