﻿using System;
using System.Collections.Generic;
namespace Prime;

public class Program
{
    static void Main()
    {
        int startNum = 1;
        int endNum = 50;
        int[] primes = FindPrimesInRange(startNum, endNum);

        Console.WriteLine($"Prime numbers between {startNum} and {endNum}:");
        foreach (var prime in primes)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();
    }

    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primeList = new List<int>();

        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primeList.Add(num);
            }
        }

        return primeList.ToArray();
    }
    
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}