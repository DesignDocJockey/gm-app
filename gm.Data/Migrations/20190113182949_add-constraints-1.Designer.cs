﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gm.Data;

namespace gm.Data.Migrations
{
    [DbContext(typeof(TimeSheetDBContext))]
    [Migration("20190113182949_add-constraints-1")]
    partial class addconstraints1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("gm.Core.Models.TimesheetDataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Approved");

                    b.Property<decimal>("BillableRate");

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<decimal>("CostAmount");

                    b.Property<decimal>("CostRate");

                    b.Property<string>("Currency");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Department");

                    b.Property<string>("ExternalReferenceURL");

                    b.Property<string>("FirstName");

                    b.Property<double>("Hours");

                    b.Property<double>("HoursRounded");

                    b.Property<bool>("Invoiced");

                    b.Property<bool>("IsBillable");

                    b.Property<bool>("IsEmployee");

                    b.Property<string>("LastName");

                    b.Property<string>("Project")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ProjectCode")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<Guid>("Uuid");

                    b.HasKey("Id");

                    b.ToTable("TimeSheets");
                });
#pragma warning restore 612, 618
        }
    }
}
