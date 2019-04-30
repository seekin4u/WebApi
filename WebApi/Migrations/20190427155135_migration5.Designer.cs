﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Contexts;

namespace WebApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190427155135_migration5")]
    partial class migration5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName");

                    b.Property<int?>("LessonId");

                    b.Property<int>("TeacherId");

                    b.HasKey("GroupId");

                    b.HasIndex("LessonId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("WebApi.Models.Hall", b =>
                {
                    b.Property<int>("HallId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HallAviability");

                    b.Property<string>("HallLocation");

                    b.Property<string>("HallName");

                    b.HasKey("HallId");

                    b.ToTable("Hall");
                });

            modelBuilder.Entity("WebApi.Models.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HallId1");

                    b.Property<int?>("SubjectingId1");

                    b.HasKey("LessonId");

                    b.HasIndex("HallId1");

                    b.HasIndex("SubjectingId1");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("WebApi.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameSurname");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("WebApi.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName");

                    b.HasKey("SubjectId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("WebApi.Models.Subjecting", b =>
                {
                    b.Property<int>("SubjectingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<int>("SubjectId");

                    b.Property<int>("SubjectingTeachers");

                    b.HasKey("SubjectingId");

                    b.ToTable("Subjecting");
                });

            modelBuilder.Entity("WebApi.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherGrade");

                    b.Property<string>("TeacherNameSurname");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("WebApi.Models.Group", b =>
                {
                    b.HasOne("WebApi.Models.Lesson")
                        .WithMany("LessonGroups")
                        .HasForeignKey("LessonId");
                });

            modelBuilder.Entity("WebApi.Models.Lesson", b =>
                {
                    b.HasOne("WebApi.Models.Hall", "HallId")
                        .WithMany()
                        .HasForeignKey("HallId1");

                    b.HasOne("WebApi.Models.Subjecting", "SubjectingId")
                        .WithMany()
                        .HasForeignKey("SubjectingId1");
                });
#pragma warning restore 612, 618
        }
    }
}
