using System.ComponentModel.DataAnnotations;


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

