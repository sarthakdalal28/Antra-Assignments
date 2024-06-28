namespace Assignment03.Interface;

public interface IInstructorService : IPersonService
{
    string Department { get; set; }
    bool IsHead { get; set; }
    DateTime JoinDate { get; set; }
}