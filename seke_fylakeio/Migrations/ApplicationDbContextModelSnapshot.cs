﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using seke_fylakeio.Data;

namespace seke_fylakeio.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("seke_fylakeio.Model.Zygisma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("GrossWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOk")
                        .HasColumnType("bit");

                    b.Property<decimal>("NetWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TareWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Vehicle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zygisma");
                });
#pragma warning restore 612, 618
        }
    }
}
