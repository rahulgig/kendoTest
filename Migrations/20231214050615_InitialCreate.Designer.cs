﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kendoTest.Models;

#nullable disable

namespace kendoTest.Migrations
{
    [DbContext(typeof(DB407Context))]
    [Migration("20231214050615_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LedgerEntry407", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CurrentIncomeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CurrentIncomeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CurrentQuantity")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("EntryType")
                        .HasColumnType("int");

                    b.Property<decimal>("ExpenditureAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ExpenditureQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("ExpenditureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FormNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("IncomeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("IncomeQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("IncomeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PendingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PendingQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("PendingRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PreparedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreparedByPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Report407ModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Report407ModelId");

                    b.ToTable("LedgerEntry407");
                });

            modelBuilder.Entity("kendoTest.Models.Iteam407", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("EntryFormNo")
                        .HasColumnType("int");

                    b.Property<long?>("Report407ModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Report407ModelId");

                    b.ToTable("Iteam407");
                });

            modelBuilder.Entity("kendoTest.Models.Report407Model", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("FiscalYear")
                        .HasColumnType("int");

                    b.Property<string>("FormName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MLPFormNo")
                        .HasColumnType("int");

                    b.Property<string>("NameoftheGoods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferenceNumber")
                        .HasColumnType("int");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Report407");
                });

            modelBuilder.Entity("LedgerEntry407", b =>
                {
                    b.HasOne("kendoTest.Models.Report407Model", null)
                        .WithMany("LedgerEntries")
                        .HasForeignKey("Report407ModelId");
                });

            modelBuilder.Entity("kendoTest.Models.Iteam407", b =>
                {
                    b.HasOne("kendoTest.Models.Report407Model", null)
                        .WithMany("Items")
                        .HasForeignKey("Report407ModelId");
                });

            modelBuilder.Entity("kendoTest.Models.Report407Model", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("LedgerEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
