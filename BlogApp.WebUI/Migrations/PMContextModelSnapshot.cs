﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectManagement.Data.Concrete.EFCore;

namespace ProjectManagement.WebUI.Migrations
{
    [DbContext(typeof(PMContext))]
    partial class PMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectManagement.Entity.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ProjectManagement.Entity.Sample", b =>
                {
                    b.Property<int>("SampleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AccessoryOrderDate")
                        .HasColumnType("Date");

                    b.Property<string>("AccessoryTermin");

                    b.Property<string>("AdditionalFile");

                    b.Property<string>("Artikel")
                        .IsRequired();

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<string>("Customer")
                        .IsRequired();

                    b.Property<string>("CustomerModelNo")
                        .IsRequired();

                    b.Property<string>("DelayDescription");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("Date");

                    b.Property<string>("DeliveryTime");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Image");

                    b.Property<DateTime?>("MeshFinishDate")
                        .HasColumnType("Date");

                    b.Property<string>("ModelDescription");

                    b.Property<DateTime?>("PaintDeliveryDate")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("PaintFinishDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("Date");

                    b.Property<string>("RequestNo")
                        .IsRequired();

                    b.Property<int>("RequestedCount");

                    b.Property<int>("SampleState");

                    b.Property<string>("SampleType")
                        .IsRequired();

                    b.Property<DateTime?>("SewingFinishDate")
                        .HasColumnType("Date");

                    b.Property<string>("Size")
                        .IsRequired();

                    b.Property<DateTime>("Termin")
                        .HasColumnType("Date");

                    b.HasKey("SampleId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Samples");
                });

            modelBuilder.Entity("ProjectManagement.Entity.Sample", b =>
                {
                    b.HasOne("ProjectManagement.Entity.Employee", "Employee")
                        .WithMany("Samples")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
