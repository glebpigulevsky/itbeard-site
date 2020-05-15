﻿// <auto-generated />
using System;
using Itbeard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Itbeard.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200515211724_AddedStatisticsTable")]
    partial class AddedStatisticsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Itbeard.Data.Entites.Statistic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Browser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Device")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferrerUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UrlId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UrlId");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("Itbeard.Data.Entites.Url", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("TargetUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShortName")
                        .IsUnique()
                        .HasFilter("[ShortName] IS NOT NULL");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("Itbeard.Data.Entites.Statistic", b =>
                {
                    b.HasOne("Itbeard.Data.Entites.Url", "Url")
                        .WithMany("Statistics")
                        .HasForeignKey("UrlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
