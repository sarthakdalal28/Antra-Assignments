using System;

namespace TimeOfDay
{
    class Program
    {
        static void Main()
        {

            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            
            if (hour >= 0 && hour < 6)
            {
                Console.WriteLine("Good Night");
            }
            if (hour >= 6 && hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (hour >= 18)
            {
                Console.WriteLine("Good Evening");
            }
        }
    }
}