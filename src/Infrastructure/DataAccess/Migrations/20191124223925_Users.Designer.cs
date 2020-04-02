﻿// <auto-generated />
using System;
using Infrastructure.EntityFrameworkDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.EntityFrameworkDataAccess.Migrations
{
    using DataAccess;

    [DbContext(typeof(MangaContext))]
    [Migration("20191124223925_Users")]
    partial class Users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infrastructure.EntityFrameworkDataAccess.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                            CustomerId = new Guid("197d0438-e04b-453d-b5de-eca05960c6ae")
                        });
                });

            modelBuilder.Entity("Infrastructure.EntityFrameworkDataAccess.Credit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Credit");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                            AccountId = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                            Amount = 400m,
                            TransactionDate = new DateTime(2019, 11, 24, 22, 39, 24, 636, DateTimeKind.Utc).AddTicks(5740)
                        });
                });

            modelBuilder.Entity("Infrastructure.EntityFrameworkDataAccess.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("197d0438-e04b-453d-b5de-eca05960c6ae"),
                            Name = "Test User",
                            SSN = "19860817-9999"
                        });
                });

            modelBuilder.Entity("Infrastructure.EntityFrameworkDataAccess.Debit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Debit");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                            AccountId = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                            Amount = 400m,
                            TransactionDate = new DateTime(2019, 11, 24, 22, 39, 24, 636, DateTimeKind.Utc).AddTicks(6780)
                        });
                });

            modelBuilder.Entity("Infrastructure.EntityFrameworkDataAccess.User", b =>
                {
                    b.Property<string>("ExternalUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExternalUserId", "CustomerId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ExternalUserId = "github/ivanpaulovich",
                            CustomerId = new Guid("197d0438-e04b-453d-b5de-eca05960c6ae")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}