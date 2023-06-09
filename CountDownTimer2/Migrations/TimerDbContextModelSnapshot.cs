﻿// <auto-generated />
using System;
using CountDownTimer2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CountDownTimer2.Migrations
{
    [DbContext(typeof(TimerDbContext))]
    partial class TimerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CountDownTimer.Data.TimerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("TimerFinished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimerStarted")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TimerEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
