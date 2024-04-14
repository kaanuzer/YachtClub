﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.BrokerageFirm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BrokerageFirms");
                });

            modelBuilder.Entity("Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("YachtId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YachtId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Domain.Entities.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Domain.Entities.ManufacturerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ModelEndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModelStartDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("YachtCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("YachtCategoryId");

                    b.ToTable("ManufacturerModels");
                });

            modelBuilder.Entity("Domain.Entities.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfferDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OfferPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OfferType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YachtId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YachtId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("RentalEndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<decimal>("RentalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("RentalStartDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YachtId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YachtId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Domain.Entities.Yacht", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrokerageFirmId")
                        .HasColumnType("int");

                    b.Property<int?>("Cabin")
                        .HasColumnType("int");

                    b.Property<string>("Condition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CruisingSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fuel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Heads")
                        .HasColumnType("int");

                    b.Property<string>("HullMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int?>("MaxSpeed")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("YachtCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("YachtName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrokerageFirmId");

                    b.HasIndex("ManufacturerId")
                        .IsUnique();

                    b.HasIndex("YachtCategoryId");

                    b.ToTable("Yachts");
                });

            modelBuilder.Entity("Domain.Entities.YachtCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YachtCategories");
                });

            modelBuilder.Entity("Domain.Entities.YachtFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YachtFeatureCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YachtFeatureCategoryId");

                    b.ToTable("YachtFeatures");
                });

            modelBuilder.Entity("Domain.Entities.YachtFeatureCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YachtId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YachtId");

                    b.ToTable("YachtFeatureCategories");
                });

            modelBuilder.Entity("Domain.Entities.YachtImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YachtId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YachtId");

                    b.ToTable("YachtImages");
                });

            modelBuilder.Entity("Domain.Entities.Comment", b =>
                {
                    b.HasOne("Domain.Entities.Yacht", "Yacht")
                        .WithMany("Comments")
                        .HasForeignKey("YachtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yacht");
                });

            modelBuilder.Entity("Domain.Entities.ManufacturerModel", b =>
                {
                    b.HasOne("Domain.Entities.Manufacturer", "Manufacturer")
                        .WithMany("ManufacturerModels")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.YachtCategory", "YachtCategory")
                        .WithMany("manufacturerModels")
                        .HasForeignKey("YachtCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");

                    b.Navigation("YachtCategory");
                });

            modelBuilder.Entity("Domain.Entities.Offer", b =>
                {
                    b.HasOne("Domain.Entities.Yacht", "Yacht")
                        .WithMany("Offers")
                        .HasForeignKey("YachtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yacht");
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.HasOne("Domain.Entities.Yacht", "Yacht")
                        .WithMany("Rentals")
                        .HasForeignKey("YachtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yacht");
                });

            modelBuilder.Entity("Domain.Entities.Yacht", b =>
                {
                    b.HasOne("Domain.Entities.BrokerageFirm", "BrokerageFirm")
                        .WithMany("Yachts")
                        .HasForeignKey("BrokerageFirmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Manufacturer", "Manufacturer")
                        .WithOne("Yacht")
                        .HasForeignKey("Domain.Entities.Yacht", "ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.YachtCategory", "YachtCategory")
                        .WithMany("Yachts")
                        .HasForeignKey("YachtCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrokerageFirm");

                    b.Navigation("Manufacturer");

                    b.Navigation("YachtCategory");
                });

            modelBuilder.Entity("Domain.Entities.YachtFeature", b =>
                {
                    b.HasOne("Domain.Entities.YachtFeatureCategory", "YachtFeatureCategory")
                        .WithMany("YachtFeatures")
                        .HasForeignKey("YachtFeatureCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YachtFeatureCategory");
                });

            modelBuilder.Entity("Domain.Entities.YachtFeatureCategory", b =>
                {
                    b.HasOne("Domain.Entities.Yacht", "Yacht")
                        .WithMany("YachtFeatureCategories")
                        .HasForeignKey("YachtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yacht");
                });

            modelBuilder.Entity("Domain.Entities.YachtImage", b =>
                {
                    b.HasOne("Domain.Entities.Yacht", "Yacht")
                        .WithMany("YachtImages")
                        .HasForeignKey("YachtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yacht");
                });

            modelBuilder.Entity("Domain.Entities.BrokerageFirm", b =>
                {
                    b.Navigation("Yachts");
                });

            modelBuilder.Entity("Domain.Entities.Manufacturer", b =>
                {
                    b.Navigation("ManufacturerModels");

                    b.Navigation("Yacht");
                });

            modelBuilder.Entity("Domain.Entities.Yacht", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Offers");

                    b.Navigation("Rentals");

                    b.Navigation("YachtFeatureCategories");

                    b.Navigation("YachtImages");
                });

            modelBuilder.Entity("Domain.Entities.YachtCategory", b =>
                {
                    b.Navigation("Yachts");

                    b.Navigation("manufacturerModels");
                });

            modelBuilder.Entity("Domain.Entities.YachtFeatureCategory", b =>
                {
                    b.Navigation("YachtFeatures");
                });
#pragma warning restore 612, 618
        }
    }
}
