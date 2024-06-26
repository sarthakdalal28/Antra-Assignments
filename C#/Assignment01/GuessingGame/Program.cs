using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Guess a number between 1 and 3:");

            while (true)
            {
                int guessedNumber = int.Parse(Console.ReadLine());
                
                if (guessedNumber < 1 || guessedNumber > 3)
                {
                    Console.WriteLine("Your guess is outside the valid range (1-3). Try again.");
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    break;
                }
            }
        }
    }
}