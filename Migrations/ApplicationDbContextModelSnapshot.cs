﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignment_1_webapi.Data;

#nullable disable

namespace assignment_1_webapi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("assignment_1_webapi.Entities.CourseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfCredits")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("courseModels");
                });

            modelBuilder.Entity("assignment_1_webapi.Entities.SemesterModel", b =>
                {
                    b.Property<int>("SemesterCode")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SemesterCode");

                    b.ToTable("semesterModels");
                });

            modelBuilder.Entity("assignment_1_webapi.Entities.StudentModel", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JoiningBatch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SemesterCode")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("SemesterCode");

                    b.ToTable("studentModels");
                });

            modelBuilder.Entity("assignment_1_webapi.Entities.StudentModel", b =>
                {
                    b.HasOne("assignment_1_webapi.Entities.SemesterModel", "Semester")
                        .WithMany()
                        .HasForeignKey("SemesterCode");

                    b.Navigation("Semester");
                });
#pragma warning restore 612, 618
        }
    }
}