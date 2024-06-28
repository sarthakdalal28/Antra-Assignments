namespace Assignment03.Interface;

public interface IDepartmentService
{
    string DepartmentName { get; set; }
    Instructor Head { get; set; }
    decimal Budget { get; set; }
    List<Course> Courses { get; set; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
}