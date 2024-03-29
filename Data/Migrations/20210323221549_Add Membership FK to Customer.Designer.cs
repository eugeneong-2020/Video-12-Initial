﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210323221549_Add Membership FK to Customer")]
    partial class AddMembershipFKtoCustomer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Birth_Date");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("First_Name");

                    b.Property<string>("Gender")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Last_Name");

                    b.Property<string>("MembershipCode")
                        .HasColumnType("varchar(6)")
                        .HasColumnName("Membership_Code");

                    b.HasKey("Id");

                    b.HasIndex("MembershipCode");

                    b.ToTable("T_Customer");
                });

            modelBuilder.Entity("Data.Entity.Membership", b =>
                {
                    b.Property<string>("MembershipCode")
                        .HasColumnType("varchar(6)")
                        .HasColumnName("Membership_Code");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("MembershipCode");

                    b.ToTable("T_Membership");
                });

            modelBuilder.Entity("Data.Entity.Customer", b =>
                {
                    b.HasOne("Data.Entity.Membership", "Membership")
                        .WithMany()
                        .HasForeignKey("MembershipCode");

                    b.Navigation("Membership");
                });
#pragma warning restore 612, 618
        }
    }
}
