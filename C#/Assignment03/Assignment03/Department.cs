using Assignment03.Interface;

namespace Assignment03;

public class Department : IDepartmentService
{
    public string DepartmentName { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}