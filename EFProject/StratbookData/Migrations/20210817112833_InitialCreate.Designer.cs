﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StratbookData;

namespace StratbookData.Migrations
{
    [DbContext(typeof(StratbookContext))]
    [Migration("20210817112833_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StratbookData.Map", b =>
                {
                    b.Property<int>("MapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MapName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MapId");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("StratbookData.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("StratbookData.Strategy", b =>
                {
                    b.Property<int>("StrategyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Map")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrategyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StrategyRating")
                        .HasColumnType("int");

                    b.Property<string>("StrategyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("StrategyId");

                    b.HasIndex("UserId");

                    b.ToTable("Strategies");
                });

            modelBuilder.Entity("StratbookData.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AccountType")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StratbookData.Strategy", b =>
                {
                    b.HasOne("StratbookData.User", null)
                        .WithMany("Strategies")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("StratbookData.User", b =>
                {
                    b.Navigation("Strategies");
                });
#pragma warning restore 612, 618
        }
    }
}