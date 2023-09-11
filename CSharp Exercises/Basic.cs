﻿


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class BasicExercises
{
    /**
    Write a C# program to find the largest and lowest values from three integer values.
    **/
    public static void Basic39()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInput second integer:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInput third integer:");
        int z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
        Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));

    }

    /**
     * Check the nearest value of 20 of two given integers and return 0 if two numbers are same
     * 
     * Nested ternary!
     * 
    **/
    public static void Basic40()
    {
        const int REFERENCE_VALUE = 20;

        Console.WriteLine("\nWrite first number to compare: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWrite second number to compare: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int comparisonX = Math.Abs(x - REFERENCE_VALUE); // ABS(2 - 20) = 18 
        int comparisonY = Math.Abs(y - REFERENCE_VALUE); // ABS(18 - 20) = 2

        Console.WriteLine("Closest to " + REFERENCE_VALUE + " is :"); 
        Console.WriteLine(comparisonX == comparisonY ? 0 : comparisonX > comparisonY ? y : x); 
    }

    /**
     * Check if a given string contains 'w' character between 1 and 3 times
     * 
     * Lambda expression: is a concise way to define anonymous methods or functions in programming languages
    **/
    public static void Basic41()
    {
        Console.WriteLine("Input a string (contains at least one 'w' char) : ");
        string str = Console.ReadLine();

        var count = str.Count(s => s == 'w'); // lambda expression counting how many characters in the string str are equal to the character 'w'
        Console.WriteLine("The string contains 'w' character  between 1 and 3 times: ");
        Console.WriteLine(count >= 1 && count <= 3);

    }

}