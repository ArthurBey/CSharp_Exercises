using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/**
 Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.
**/
public class Launcher
{
    public static void Main()
    {
        Console.WriteLine("Enter Basic Exercise n°:\n");

        // If user input can be converted/parsed into an integer, user input will be storer inside 'exerciseNumber' and tryparse returns true
        if (int.TryParse(Console.ReadLine(), out int exerciseNumber)) //  'out' parameter => if conversion successful will store result. The out keyword indicates that the result variable is an output parameter, which means it will be modified by the method.
        {
            string methodName = "Basic" + exerciseNumber;

            // Use reflection to get the method with the specified name
            var methodInfo = typeof(BasicExercises).GetMethod(methodName);

            if (methodInfo != null)
            {
                // Invoke the method dynamically
                methodInfo.Invoke(null, null);
            }
            else
            {
                Console.WriteLine("Exercise not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}