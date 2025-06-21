using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using StudentCourses.Models;
=======
>>>>>>> 73291c006c9d2e460b5e3b9546d8720894a754b9


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<StudentCourse> StudentCourses { get; set; }
}
