


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
}