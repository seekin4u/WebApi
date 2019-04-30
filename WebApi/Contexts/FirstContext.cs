﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Hall> Hall { get; set; }
        public DbSet<Subjecting> Subjectings { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hall>().HasData(
                new Hall[]
                {
                new Hall { HallName = "Аудитория 1", HallLocation = "1 этаж корпуса", HallAviability = true},
                new Hall { HallName = "Аудитория 2", HallLocation = "1 этаж корпуса", HallAviability = true},
                new Hall { HallName = "Аудитория 3", HallLocation = "1 этаж корпуса", HallAviability = true},
                new Hall { HallName = "Аудитория 4", HallLocation = "2 этаж корпуса", HallAviability = true},
                new Hall { HallName = "Аудитория 5", HallLocation = "3 этаж корпуса", HallAviability = true},
                new Hall { HallName = "Аудитория 6", HallLocation = "3 этаж корпуса", HallAviability = true},
                new Hall { HallName = "Аудитория 7", HallLocation = "4 этаж корпуса", HallAviability = true}
                });
            base.OnModelCreating(modelBuilder);
        }*/
    }
}