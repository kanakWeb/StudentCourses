using Microsoft.EntityFrameworkCore;
using StudentCourses.Models;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<StudentCourse> StudentCourses { get; set; }
}
