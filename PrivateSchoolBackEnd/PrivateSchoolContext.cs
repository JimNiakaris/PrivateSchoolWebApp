using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrivateSchoolBackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.API
{
    public class PrivateSchoolContext : DbContext

    {
        public PrivateSchoolContext(DbContextOptions<PrivateSchoolContext> options) : base(options) { }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Assignment>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.Assignments);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Trainers)
                .WithMany(e => e.Courses);

            modelBuilder.Entity<Student>()
                .Property(e => e.Tuitions)
                .HasPrecision(5, 1);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.Students);

        }
        //Alternative connection string
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Server=JNIAKARIS\\SQLEXPRESS;Database=PrivateSchool;Trusted_Connection=True;");
        //}
    }
}
