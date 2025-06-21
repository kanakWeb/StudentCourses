using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class StudentCoursesController : Controller
{
    private readonly ApplicationDbContext _context;

    public StudentCoursesController(ApplicationDbContext context)
    {
        _context = context;
    }

    private CourseStatus GetStatus(int marks)
    {
        if (marks < 50) return CourseStatus.NeedsImprovement;
        if (marks < 80) return CourseStatus.Good;
        return CourseStatus.Excellent;
    }

    public async Task<IActionResult> Index(CourseStatus? status)
    {
        var query = _context.StudentCourses.AsQueryable();

        if (status != null)
        {
            query = query.Where(s => s.Status == status);
        }

        ViewBag.StatusList = Enum.GetValues(typeof(CourseStatus)).Cast<CourseStatus>().ToList();
        ViewBag.SelectedStatus = status;

        return View(await query.ToListAsync());
    }

    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("StudentName,CourseTitle,TotalMarks")] StudentCourse studentCourse)
    {
        if (ModelState.IsValid)
        {
            studentCourse.Status = GetStatus(studentCourse.TotalMarks);
            _context.Add(studentCourse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(studentCourse);
    }
}
