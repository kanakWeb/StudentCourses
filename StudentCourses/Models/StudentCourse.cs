using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace StudentCourses.Models
{

    public class StudentCourse
    {
        [Key] // 👈 This makes it a primary key
        public int Id { get; set; }

        [Required]
        public string? StudentName { get; set; }

        [Required]
        public string? CourseTitle { get; set; }

        [Range(0, 100)]
        public int TotalMarks { get; set; }

        public CourseStatus Status { get; set; }
    }


    public enum CourseStatus
    {
        NeedsImprovement,
        Good,
        Excellent,
        Poor
    }
}
=======

public class StudentCourse
{
    public int Id { get; set; }

    [Required]
    public string? StudentName { get; set; }

    [Required]
    public string? CourseTitle { get; set; }

    [Range(0, 100)]
    public int TotalMarks { get; set; }

    public CourseStatus Status { get; set; }
}
public enum CourseStatus
{
    NeedsImprovement,
    Good,
    Excellent
}

>>>>>>> 73291c006c9d2e460b5e3b9546d8720894a754b9
