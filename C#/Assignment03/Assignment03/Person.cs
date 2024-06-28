using Assignment03.Interface;

namespace Assignment03;

public abstract class Person : IPersonService
{
    public string Name { get; set; }
    private DateTime _dateOfBirth;
    private decimal _salary;
    private List<string> _addresses = new List<string>();


    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set { _dateOfBirth = value; }
    }

    public decimal Salary
    {
        get { return _salary; }
        set
        {
            if (value >= 0)
                _salary = value;
            else
                throw new ArgumentOutOfRangeException("Salary cannot be negative");
        }
    }

    public void AddAddress(string address)
    {
        _addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return _addresses;
    }

    public int CalculateAge()
    {
        int age = DateTime.Now.Year - _dateOfBirth.Year;
        if (DateTime.Now.DayOfYear < _dateOfBirth.DayOfYear)
            age--;
        return age;
    }

    public abstract decimal CalculateSalary();
}