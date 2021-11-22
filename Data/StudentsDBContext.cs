using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This is included manually
using Microsoft.EntityFrameworkCore;
using StudentsDB.Models;

namespace StudentsDB.Data
{
    public class StudentsDBContext : DbContext
    {
        // THIS IS CONSTRUCTOR
        public StudentsDBContext(DbContextOptions<StudentsDBContext> options) : base(options)
        {}

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}