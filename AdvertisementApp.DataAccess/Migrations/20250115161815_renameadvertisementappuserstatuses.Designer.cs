﻿// <auto-generated />
using System;
using AdvertisementApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvertisementApp.DataAccess.Migrations
{
    [DbContext(typeof(AdvertisementContext))]
    [Migration("20250115161815_renameadvertisementappuserstatuses")]
    partial class renameadvertisementappuserstatuses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvertisementApp.Entities.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Advertisements");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AdvertisementAppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertisementAppUserStatusId")
                        .HasColumnType("int");

                    b.Property<int>("AdvertisementId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("CvPath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MilitaryStatusId")
                        .HasColumnType("int");

                    b.Property<int>("WorkExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementAppUserStatusId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("MilitaryStatusId");

                    b.HasIndex("AdvertisementId", "AppUserId")
                        .IsUnique();

                    b.ToTable("AdvertisementAppUsers");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AdvertisementAppUserStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("AdvertisementAppUserStatuses");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AppUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("AppRoleId", "AppUserId")
                        .IsUnique();

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definiton")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.MilitaryStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("MilitaryStatuses");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.ProvidedService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("ProvidedServices");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AdvertisementAppUser", b =>
                {
                    b.HasOne("AdvertisementApp.Entities.AdvertisementAppUserStatus", "AdvertisementAppUserStatus")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AdvertisementAppUserStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdvertisementApp.Entities.Advertisement", "Advertisement")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdvertisementApp.Entities.AppUser", "AppUser")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdvertisementApp.Entities.MilitaryStatus", "MilitaryStatus")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("MilitaryStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advertisement");

                    b.Navigation("AdvertisementAppUserStatus");

                    b.Navigation("AppUser");

                    b.Navigation("MilitaryStatus");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AppUser", b =>
                {
                    b.HasOne("AdvertisementApp.Entities.Gender", "Gender")
                        .WithMany("AppUsers")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AppUserRole", b =>
                {
                    b.HasOne("AdvertisementApp.Entities.AppRole", "AppRole")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdvertisementApp.Entities.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.Advertisement", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AdvertisementAppUserStatus", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AppRole", b =>
                {
                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.AppUser", b =>
                {
                    b.Navigation("AdvertisementAppUsers");

                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.Gender", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("AdvertisementApp.Entities.MilitaryStatus", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
