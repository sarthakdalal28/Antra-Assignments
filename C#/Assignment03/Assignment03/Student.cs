using Assignment03.Interface;

namespace Assignment03;

public class Student : Person, IStudentService
{
    private List<Course> _courses = new List<Course>();

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public List<Course> GetCourses()
    {
        return _courses;
    }

    public double CalculateGPA()
    {
        if (_courses.Count == 0) return 0;

        double totalPoints = 0.0;
        int totalCourses = _courses.Count;

        foreach (var course in _courses)
        {
            switch (course.Grade)
            {
                case 'A': totalPoints += 4.0; break;
                case 'B': totalPoints += 3.2; break;
                case 'C': totalPoints += 2.4; break;
                case 'D': totalPoints += 1.6; break;
                case 'E': totalPoints += 0.8; break;
                case 'F': totalPoints += 0; break;
            }
        }

        return totalPoints / totalCourses;
    }

    public override decimal CalculateSalary()
    {
        return 0; 
    }
}