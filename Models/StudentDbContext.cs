using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsMangment.Models
{
    public class StudentDbContext: DbContext 
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options): base (options) 
        {

        }

        public DbSet<Student> Students { set; get;  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    FullName = "John Snow",
                    StudentID = 112233,
                    Email = "John@it.com",
                    CourseTitle = "IT",

                });
        }
    }
}
