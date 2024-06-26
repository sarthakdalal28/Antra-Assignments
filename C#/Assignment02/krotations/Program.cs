using System;

namespace krotations;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the array of integers (space-separated):");
        string[] inputArray = Console.ReadLine().Split(' ');
        
        int[] arr = Array.ConvertAll(inputArray, int.Parse);

        Console.WriteLine("Enter the value of k:");
        int k = int.Parse(Console.ReadLine());

        int n = arr.Length;

        int[] sum = new int[n];
        for (int r = 1; r <= k; r++)
        {
            int[] rotated = RotateArrayRight(arr, r);

            for (int i = 0; i < n; i++)
            {
                sum[i] += rotated[i];
            }
        }

        sum = RotateArrayRight(sum, (n - 1));
        Console.WriteLine("sum[] = [" + string.Join(", ", sum) + "]");

    }
    static int[] RotateArrayRight(int[] arr, int r)
    {
        int n = arr.Length;
        int[] rotated = new int[n];

        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + r) % n;
            rotated[newIndex] = arr[i];
        }

        return rotated;
    }
}