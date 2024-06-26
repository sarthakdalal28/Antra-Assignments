using System;

class Program
{
    static void Main()
    {
        int[] originalArray = new int[10];

        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = i * 2;

            
        }
        Console.WriteLine("Original Array:");
        PrintArray(originalArray);

        int[] newArray = new int[originalArray.Length];

            for (int j = 0; j < originalArray.Length; j++)
            {
                newArray[j] = originalArray[j];
            }

            Console.WriteLine("\nCopied Array:");
            PrintArray(newArray);    
    }
        
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }