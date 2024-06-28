using Assignment03.Interface;

namespace Assignment03;

public class Instructor : Person, IInstructorService
{
    public string Department { get; set; }
    public bool IsHead { get; set; }
    public DateTime JoinDate { get; set; }

    public override decimal CalculateSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        if (DateTime.Now.DayOfYear < JoinDate.DayOfYear)
            yearsOfExperience--;

        return Salary + (yearsOfExperience * 1500); // Added bonus per year of experience
    }
}