﻿// <auto-generated />
using System;
using GraniteHouse.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraniteHouse.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191129114801_bigUpdate")]
    partial class bigUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraniteHouse.Models.Appointments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppointmentDate");

                    b.Property<string>("CustomerAddress");

                    b.Property<string>("CustomerEmail");

                    b.Property<string>("CustomerName");

                    b.Property<string>("CustomerPhoneNumber");

                    b.Property<string>("SalesPersonId");

                    b.Property<decimal>("TotalAppointment");

                    b.Property<bool>("isCompleted");

                    b.Property<bool>("isConfirmed");

                    b.HasKey("Id");

                    b.HasIndex("CustomerPhoneNumber");

                    b.HasIndex("SalesPersonId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("GraniteHouse.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("GraniteHouse.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GraniteHouse.Models.Customer", b =>
                {
                    b.Property<string>("CusPhone")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CusAddress");

                    b.Property<string>("CusEmail");

                    b.Property<string>("CusName");

                    b.HasKey("CusPhone");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("GraniteHouse.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available");

                    b.Property<int>("BrandId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("ProductTypeId");

                    b.Property<int>("Quantity");

                    b.Property<string>("ShadeColor");

                    b.Property<int>("SpecialTagsID");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SpecialTagsID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GraniteHouse.Models.ProductsSelectedForAppointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppointmentId");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("TotalQuantity");

                    b.Property<string>("productName");

                    b.Property<int>("quantity");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsSelectedForAppointment");
                });

            modelBuilder.Entity("GraniteHouse.Models.ProductTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("GraniteHouse.Models.SpecialTags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("SpecialTags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GraniteHouse.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name");

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("GraniteHouse.Models.Appointments", b =>
                {
                    b.HasOne("GraniteHouse.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerPhoneNumber");

                    b.HasOne("GraniteHouse.Models.ApplicationUser", "SalesPerson")
                        .WithMany()
                        .HasForeignKey("SalesPersonId");
                });

            modelBuilder.Entity("GraniteHouse.Models.Products", b =>
                {
                    b.HasOne("GraniteHouse.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraniteHouse.Models.ProductTypes", "ProductTypes")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraniteHouse.Models.SpecialTags", "SpecialTags")
                        .WithMany()
                        .HasForeignKey("SpecialTagsID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GraniteHouse.Models.ProductsSelectedForAppointment", b =>
                {
                    b.HasOne("GraniteHouse.Models.Appointments", "Appointments")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraniteHouse.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GraniteHouse.Models.ProductTypes", b =>
                {
                    b.HasOne("GraniteHouse.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
