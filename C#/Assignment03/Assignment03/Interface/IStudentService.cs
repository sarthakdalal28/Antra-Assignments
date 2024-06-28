namespace Assignment03.Interface;

public interface IStudentService : IPersonService
{
    double CalculateGPA();
    void AddCourse(Course course);
    List<Course> GetCourses();
}