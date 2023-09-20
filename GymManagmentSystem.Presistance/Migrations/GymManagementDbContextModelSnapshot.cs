﻿// <auto-generated />
using System;
using GymManagmentSystem.Presistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymManagmentSystem.Presistance.Migrations
{
    [DbContext(typeof(GymManagementDbContext))]
    partial class GymManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GymManegmentSystemDomin.Entity.Member.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("memberShip_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("memberShip_Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2417),
                            FirstName = "Baabak",
                            IsPresent = true,
                            IsValid = true,
                            LastName = "Aghaei",
                            MobileNumber = "09125595423",
                            memberShip_Id = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1990, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2432),
                            FirstName = "Leila",
                            IsPresent = true,
                            IsValid = true,
                            LastName = "Aghaei",
                            MobileNumber = "09125595281",
                            memberShip_Id = 2
                        });
                });

            modelBuilder.Entity("GymManegmentSystemDomin.Entity.Membership.MemberShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MemberShips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2500),
                            Duration = 12,
                            Name = 2,
                            Price = 25000.0
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2503),
                            Duration = 15,
                            Name = 1,
                            Price = 30000.0
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2504),
                            Duration = 20,
                            Name = 0,
                            Price = 35000.0
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2505),
                            Duration = 1,
                            Name = 3,
                            Price = 1000.0
                        });
                });

            modelBuilder.Entity("GymManegmentSystemDomin.Entity.Member.Member", b =>
                {
                    b.HasOne("GymManegmentSystemDomin.Entity.Membership.MemberShip", "MemberShip")
                        .WithMany()
                        .HasForeignKey("memberShip_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberShip");
                });
#pragma warning restore 612, 618
        }
    }
}
