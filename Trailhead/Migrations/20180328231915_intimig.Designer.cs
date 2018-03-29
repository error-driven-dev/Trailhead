﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Trailhead.Models;

namespace Trailhead.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180328231915_intimig")]
    partial class intimig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Trailhead.Models.API.NationalPark", b =>
                {
                    b.Property<int>("NationalParkID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FullName");

                    b.Property<string>("LatLong");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("NationalParkID");

                    b.ToTable("NationalParks");
                });
#pragma warning restore 612, 618
        }
    }
}
