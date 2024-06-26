using System;

namespace PyramidStar
{
    class Program
    {
        static void Main()
        {
            int rows = 5; 

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); 
            }
        }
    }
}