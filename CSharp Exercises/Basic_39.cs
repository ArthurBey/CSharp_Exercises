


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
/**
Write a C# program to find the largest and lowest values from three integer values.

Test Data:
Input first integer:
15
Input second integer:
25
Input third integer:
30
Sample Output
Largest of three: 30
Lowest of three: 15
**/
public class BasicExercises39
{
    public static void Main()
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
}