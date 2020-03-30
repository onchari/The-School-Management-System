﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheSma.WebApi.Models;

namespace TheSma.WebApi.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20200330185526_FirstSecod")]
    partial class FirstSecod
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheSma.WebApi.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("TheSma.WebApi.Models.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GradeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradeID");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("TheSma.WebApi.Models.Parent", b =>
                {
                    b.Property<int>("ParentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParentId");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("TheSma.WebApi.Models.Stream", b =>
                {
                    b.Property<int>("StreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("StreamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreamId");

                    b.HasIndex("ClassId");

                    b.ToTable("Stream");
                });

            modelBuilder.Entity("TheSma.WebApi.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("classesClassId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("GradeID");

                    b.HasIndex("classesClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TheSma.WebApi.Models.StudentParent", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "ParentId");

                    b.HasIndex("ParentId");

                    b.ToTable("StudentParent");
                });

            modelBuilder.Entity("TheSma.WebApi.Models.Stream", b =>
                {
                    b.HasOne("TheSma.WebApi.Models.Class", "Class")
                        .WithMany("Streams")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("TheSma.WebApi.Models.Student", b =>
                {
                    b.HasOne("TheSma.WebApi.Models.Grade", "grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeID");

                    b.HasOne("TheSma.WebApi.Models.Class", "classes")
                        .WithMany("Students")
                        .HasForeignKey("classesClassId");
                });

            modelBuilder.Entity("TheSma.WebApi.Models.StudentParent", b =>
                {
                    b.HasOne("TheSma.WebApi.Models.Parent", "Parent")
                        .WithMany("StudentParents")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSma.WebApi.Models.Student", "Student")
                        .WithMany("StudentParents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
