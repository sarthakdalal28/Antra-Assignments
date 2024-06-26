using System;

namespace LongestSequence;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the array of integers (space-separated):");
        string[] inputArray = Console.ReadLine().Split(' ');
        
        int[] arr = Array.ConvertAll(inputArray, int.Parse);
        int n = arr.Length;
        int currentLength = 1;
        int maxLength = 1;
        int index = 0;
        int startIndex = 0;
        for (int i = 1; i <= n - 1; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = index;
                }
                index = i;
                currentLength = 1;
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            startIndex = index;
        }
        Console.WriteLine("Longest sequence of equal elements:");
        for (int i = startIndex; i < startIndex + maxLength; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
