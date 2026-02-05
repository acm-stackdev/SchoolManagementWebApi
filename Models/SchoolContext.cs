using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;

namespace SchoolManagement.Models;
{
    public class SchoolContext : DbContext{
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options){}
        public DbSet<Student> Students {get; set;}
        public DbSet<Lecturer> Lecturers {get; set;}
    }
}