﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MvcStudyBuddy.Migrations.MvcStudyBuddy2
{
    [DbContext(typeof(MvcStudyBuddy2Context))]
    partial class MvcStudyBuddy2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("MvcStudyBuddy.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("current_points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("total_points")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });
#pragma warning restore 612, 618
        }
    }
}
