using System;

namespace CenturyConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of centuries: ");
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.25);
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            long nanoseconds = microseconds * 1000;
            //Console.WriteLine(2.0 / 0);
            Console.WriteLine($"{centuries} centuries, \n" +
                              $"{years} years, \n" +
                              $"{days} days, \n" +
                              $"{hours} hours, \n" +
                              $"{minutes} minutes, \n" +
                              $"{seconds} seconds, \n" +
                              $"{milliseconds} milliseconds, \n" +
                              $"{microseconds} microseconds, \n" +
                              $"{nanoseconds} nanoseconds");
        }
    }
}