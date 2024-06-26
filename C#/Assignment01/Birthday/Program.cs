using System;

namespace Birthday
{
    class Program
    {
        static void Main()
        {
            // Define the birth date of the person (example: January 1, 1990)
            DateTime birthDate = new DateTime(2000, 1, 1);
            
            TimeSpan age = DateTime.Today - birthDate;
            int ageInDays = (int)age.TotalDays;

            Console.WriteLine($"The person is {ageInDays} days old.");
            
            int daysToNextAnniversary = 10000 - (ageInDays % 10000);
            DateTime nextAnniversaryDate = DateTime.Today.AddDays(daysToNextAnniversary);

            Console.WriteLine($"The next 10,000-day anniversary will be on: {nextAnniversaryDate:d}");
        }
    }
}
