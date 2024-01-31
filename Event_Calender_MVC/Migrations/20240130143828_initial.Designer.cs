﻿// <auto-generated />
using System;
using Event_Calender_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Event_Calender_MVC.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240130143828_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Event_Calender_MVC.Models.Event", b =>
                {
                    b.Property<int>("event_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("event_id"));

                    b.Property<DateTime?>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("event_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("isfullday")
                        .HasColumnType("bit");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("themecolor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("event_id");

                    b.ToTable("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
