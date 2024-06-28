using Assignment03.Interface;

namespace Assignment03;

public class Course : ICourseService
{
    public string CourseName { get; set; }
    public char Grade { get; set; }
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();
}