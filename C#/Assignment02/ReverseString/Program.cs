using System;

namespace ReverseString;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(); 
        // Print the string in reverse using a for-loop
        Console.Write("Reversed string: ");
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine(); 
        // Print the string in reverse using a character array
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine("Reversed string: " + reversedString);
    }
}