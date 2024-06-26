using System;

namespace Exercise0302
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            for (byte i = 0; i < max; i++)//Infinite loop as byte only goes till 255
            {
                if (i == 256)
                {
                    Console.WriteLine("Warning: Byte overflow detected!");
                    break;
                }
                Console.WriteLine(i);
            }
        }
    

    }
}