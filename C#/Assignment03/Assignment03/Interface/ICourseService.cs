namespace Assignment03.Interface;

public interface ICourseService
{
    string CourseName { get; set; }
    char Grade { get; set; }
    List<Student> EnrolledStudents { get; set; }
}
