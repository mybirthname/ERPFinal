﻿// <auto-generated />
using System;
using ERP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ERP.Data.Migrations
{
    [DbContext(typeof(ERPContext))]
    [Migration("20180819021300_InitialMigration1")]
    partial class InitialMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ERP.Models.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrganizationID");

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("Street")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ERP.Models.Invoice", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AmountNet");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrderID");

                    b.Property<Guid>("OrganizationID");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<DateTime>("SendDate");

                    b.Property<int>("Status");

                    b.Property<Guid>("SupplierOrganizationID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("SupplierOrganizationID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("ERP.Models.InvoicePosition", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<Guid>("InvoiceID");

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrganizationID");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("InvoiceID");

                    b.ToTable("InvoicePositions");
                });

            modelBuilder.Entity("ERP.Models.News", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrganizationID");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("ERP.Models.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AmountNet");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrganizationID");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<DateTime>("SendDate");

                    b.Property<int>("Status");

                    b.Property<Guid?>("SupplierID");

                    b.Property<Guid?>("SupplierOrganizationID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ERP.Models.OrderPosition", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrderID");

                    b.Property<Guid>("OrganizationID");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderPositions");
                });

            modelBuilder.Entity("ERP.Models.Organization", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<Guid>("ProviderOrganizationID");

                    b.Property<string>("Remark")
                        .HasMaxLength(50);

                    b.Property<string>("Street")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Organizations");

                    b.HasData(
                        new { ID = new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"), City = "Sofia", Country = "Bulgaria", CreateBy = "Automatic Seed Function", CreateDate = new DateTime(2018, 8, 19, 5, 12, 59, 914, DateTimeKind.Local), Deleted = 0, Description = "Organization of the company which provides ", Email = "ContactCompanyEmail@CompanyDomain.com", Phone = "+359 888 123 456", ProviderOrganizationID = new Guid("00000000-0000-0000-0000-000000000000"), Remark = "Values are filled automatically", Title = "Provider Organization", UpdateBy = "Automatic Seed Function", UpdateDate = new DateTime(2018, 8, 19, 5, 12, 59, 914, DateTimeKind.Local), ZipCode = "1000" }
                    );
                });

            modelBuilder.Entity("ERP.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "065548f8-a5a6-4e2a-a30f-000b8d109ed2", ConcurrencyStamp = "1b320143-e7fc-4b68-99e8-3192a871d19e", Name = "SuperAdmin", NormalizedName = "SUPERADMIN" }
                    );
                });

            modelBuilder.Entity("ERP.Models.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("ERP.Models.StockReceipt", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AmountNet");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrderID");

                    b.Property<Guid>("OrganizationID");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<DateTime>("SendDate");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("StockReceipts");
                });

            modelBuilder.Entity("ERP.Models.StockReceiptPosition", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrganizationID");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<Guid>("StockReceiptID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("StockReceiptID");

                    b.ToTable("StockReceiptPositions");
                });

            modelBuilder.Entity("ERP.Models.Supplier", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("NrIntern")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("OrganizationID");

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("Street")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserID");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ERP.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<Guid>("OrganizationID");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "49dc92d3-0025-42eb-8bc0-b3c3acde0f39", AccessFailedCount = 0, ConcurrencyStamp = "2cc6f885-d16d-4201-9c75-865a5802ce91", CreateBy = "Automatic Seed Function", CreateDate = new DateTime(2018, 8, 19, 5, 12, 59, 900, DateTimeKind.Local), Email = "martin.stanchev87@gmail.com", EmailConfirmed = true, FirstName = "Martin", LastName = "Stanchev", LockoutEnabled = false, NormalizedEmail = "MARTIN.STANCHEV87@GMAIL.COM", NormalizedUserName = "MARTIN.STANCHEV87@GMAIL.COM", OrganizationID = new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"), PasswordHash = "AQAAAAEAACcQAAAAEIdlhRKIVQ5pUkgKProOTNtzHAGKFOlNvsSH6YrwVZQM4a1mYJMMb1tgxyIeR/3BHQ==", PhoneNumberConfirmed = false, SecurityStamp = "ff9b1d55-f039-4a65-bdb1-94c31b5001bc", TwoFactorEnabled = false, UpdateBy = "Automatic Seed Function", UpdateDate = new DateTime(2018, 8, 19, 5, 12, 59, 901, DateTimeKind.Local), UserName = "martin.stanchev87@gmail.com" }
                    );
                });

            modelBuilder.Entity("ERP.Models.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("ERP.Models.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("ERP.Models.UserRole", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "49dc92d3-0025-42eb-8bc0-b3c3acde0f39", RoleId = "065548f8-a5a6-4e2a-a30f-000b8d109ed2" }
                    );
                });

            modelBuilder.Entity("ERP.Models.UserToken", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("IdentityUserClaims");
                });

            modelBuilder.Entity("ERP.Models.Invoice", b =>
                {
                    b.HasOne("ERP.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ERP.Models.Organization", "SupplierOrganization")
                        .WithMany()
                        .HasForeignKey("SupplierOrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.InvoicePosition", b =>
                {
                    b.HasOne("ERP.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.OrderPosition", b =>
                {
                    b.HasOne("ERP.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.RoleClaim", b =>
                {
                    b.HasOne("ERP.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.StockReceipt", b =>
                {
                    b.HasOne("ERP.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.StockReceiptPosition", b =>
                {
                    b.HasOne("ERP.Models.StockReceipt", "StockReceipt")
                        .WithMany()
                        .HasForeignKey("StockReceiptID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.UserClaim", b =>
                {
                    b.HasOne("ERP.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.UserLogin", b =>
                {
                    b.HasOne("ERP.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.UserRole", b =>
                {
                    b.HasOne("ERP.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ERP.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Models.UserToken", b =>
                {
                    b.HasOne("ERP.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
