using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core;

namespace lab_32_entity_code_first_new
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CollegeContext())
            {
                var students01 = new Student();
                students01.StudentID = 14;
                students01.StudentName = "Maiwand Hussain";
                students01.DateOfBirth = new DateTime(1995, 01, 01);
                students01.Height = 192;
                students01.Weight = 89;

                db.Students.Add(students01);
                db.SaveChanges();
                Console.WriteLine(students01);
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Qualification Qualification { get; set; }
    }

    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    public class CollegeContext : DbContext
    {
        // Constructor method : bounce responsibility 
        // back up to Entity DbContext to do all the hard work
        public CollegeContext() : base() { } 
        

        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}
