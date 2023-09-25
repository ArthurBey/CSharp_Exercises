 


using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
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
     * Math.Abs() to return absolute value
     * 
    **/
    public static void Basic40()
    {
        const int REFERENCE_VALUE = 20;

        Console.WriteLine("\nWrite first number to compare: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWrite second number to compare: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int magnitudeX = Math.Abs(x - REFERENCE_VALUE); // ABS(2 - 20) = 18 
        int magnitudeY = Math.Abs(y - REFERENCE_VALUE); // ABS(18 - 20) = 2

        Console.WriteLine("Closest to " + REFERENCE_VALUE + " is :");
        Console.WriteLine(magnitudeX == magnitudeY ? 0 : magnitudeX > magnitudeY ? y : x);

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

    /**
     * Create a new string where the first 4 characters will be in lower case. Upper case if string < 4 chars.
     * 
     * Substring method : string.Substring(start index, int length) => not 'end index' !
    **/
    public static void Basic42()
    {
        Console.WriteLine("Input a string: ");
        string str = Console.ReadLine();


        if (str.Length < 4)
        {
            Console.WriteLine(str.ToUpper());
        }
        else
        {
            Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
        }

    }

    /**
     * Create a new string of every other character (odd index) from the first position of a given string
     * 
     * MAIN TAKEAWAY:
     * - Checking if [even] indice with statement"i % 2 == 0"
     * - you can initialize a string to "" with string.Empty
     * - HAD A BIG CONFUSION: ODD INDEX == EVEN num. when looking on the string character...
     * ==> "WORD" => 'O' even here (2nd position) but index is ODD (1)  
     * 
    **/
    public static void Basic44()
    {
        Console.WriteLine("Input a string: ");
        string str = Console.ReadLine();

        /** initializing it with an empty string
         * done as a starting point when you intend to build or concatenate strings in a loop or over multiple operations. 
         */

        var result = string.Empty;

        for(int i = 0; i < str.Length; i++) 
        { 
            if(i % 2 == 0)
            {
                str += str.Substring(i, 1);
            }
        }
        
        Console.WriteLine(result);

    }

    /**
     * Count a specified number in a given array of integers
     * 
     * MAIN TAKEAWAY:
     * Another lambda expression with method Count but this time on an array 
     * 
    **/
    public static void Basic45()
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

        Console.WriteLine("Number of \'" + x + "\' present in the array: ");
        Console.WriteLine(nums.Count(n => n == x));
    }

    /**
     * Compute sum of all the elements of an array of integers
     * 
     * MAIN TAKEAWAY:
     * - Interpolation of array values by converting array values into string
     * - string.Join method can be used to join array elements in a string
     * 
    **/
    public static void Basic47()
    {
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

        var sum = 0;
        for(int i = 0; i < nums.Length;i++)
        {
            sum += nums[i];
        }
        Console.WriteLine("Sum: " + sum);
    }

    /**
     * Check if the first element and the last element are equal of an array of integers. The array length is 1 or more.
     * 
     * MAIN TAKEAWAY:
     * array.Length -1 => last element
     * "Equals" method equivalent to == 
     * 
    **/
    public static void Basic48()
    {
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
        Console.WriteLine(nums.Length >= 1 && (nums[0].Equals(nums[nums.Length -1])));
    }  

    /**
     * Check if the first or the last element of the two arrays are equal
     * 
     * MAIN TAKEAWAY:
     * Equals method when already one logical operator in use
     * 
    **/
    public static void Basic49()
    {
 
        int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

        Console.WriteLine("\nArray1: [{0}]", string.Join(",", nums1));
        Console.WriteLine("\nArray2: [{0}]", string.Join(',', nums2));

        Console.WriteLine(nums1[0].Equals(nums2[0]) || nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1]));

    }

    /**
    * Check if an array contains an odd number
    * 
    * MAIN TAKEAWAY:
    * {0} is called 'composite formating' and is based on placeholders this is NOT interpolation ($"...{variable}")
    * MULTIPLE TIMES made the mistake to put the 'return false' inside the foreach after if...
    * 
   **/
    public static void Basic53()
    {
        int[] nums = { 2, 4, 5, 6, 8 };
        Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
        Console.WriteLine("\nArray contains an odd number? Result: " + OddNumberCheck(nums));
        
    }
    public static bool OddNumberCheck(int[] nums)
    {
        foreach(var n in nums)
        {
            if(n % 2 != 0)
            {
                return true;
            }
        }
        return false; // one return needs to be outside the foreach.
    }

    /**
    * Get the century from a year
    * 
    * 
    * MAIN TAKEAWAY:
    * This is what INTERPOLATION looks like, previous exemple was called 'composite formatting'
    * 
   **/
    public static void Basic54()
    {
        Console.WriteLine("Enter a year: \n");
        double year = Convert.ToInt32(Console.ReadLine());

        double century = Math.Floor((year / 100) + 1);

        Console.WriteLine($"{year} is part of the {century} century\n");
    }

    /**
    * Find the pair of adjacent elements that has 'the largest product of a given array' which is equal to a given value
    * 
    * MAIN TAKEAWAY:
    * 
   **/
    public static void Basic55()
    {
        Console.WriteLine(ArrayAdjacentElementsProduct(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
        Console.WriteLine(ArrayAdjacentElementsProduct(new int[] { 0, -1, -1, -2 }) == 2);
    }
    public static int ArrayAdjacentElementsProduct(int[] inputArray)
    {
        int arrayIndex = 0;
        int product = inputArray[arrayIndex] * inputArray[arrayIndex + 1];
        
        for (int i = 1; i < inputArray.Length - 1 /** We did one iteration **/; i++)
        {
            int currentProduct = inputArray[i] * inputArray[i + 1];
            if (currentProduct > product)
            {
                product = currentProduct;
            }
        }

        return product;
    }

    /**
    * Check if a given string is a palindrome or not
    * 
    * MAIN TAKEAWAY: My personal attempt
    * 
   **/
    public static void Basic560()
    {
        Console.WriteLine("Palindrome checker: \n");
        char[] strInput = Console.ReadLine().ToCharArray(); 
       
        Console.WriteLine(IsPalindrome(strInput));
    }
    public static bool IsPalindrome(char[] strInput)
    {
        for (int i = 0; i < strInput.Length; i++)
        {
            char strReversed = strInput[strInput.Length - i - 1];
            if (strInput[i] != strReversed)
            {
                return false;
            }
        }
        return true;
    }

    /**
    * Check if a given string is a palindrome or not
    * 
    * MAIN TAKEAWAY: Solution A
    * string method Replace(" ", "");
    * 
   **/
    public static void Basic561()
    {
        Console.WriteLine("Palindrome checker: \n");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);

        if(isPalindrome) 
        {
            Console.WriteLine("Is palindrome");
        }
        else
        {
            Console.WriteLine("Is not palindrome");
        }
    }
    public static bool IsPalindrome(string input)
    {
        //Remove spaces and convert to lowercase
        input = input.Replace(" ", "").ToLower();

        int left = 0;
        int right = input.Length - 1; // -1 because used for index

        while(left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    /**
    * Find the pair of adjacent elements that has the highest product of an given array of integers
    * 
    * MAIN TAKEAWAY:
    * AS LONG AS THE LENGTH: "<=" smaller or equal NOT ONLY "<" smaller !!! See error bellow
    * 
   **/
    public static void Basic57()
    {
        Console.WriteLine(AdjacentElementsProduct(new int[] { 1, -3, 4, -5, 1 }));
        Console.WriteLine(AdjacentElementsProduct(new int[] { 1, 3, 4, 5, 2 }));
        Console.WriteLine(AdjacentElementsProduct(new int[] { 1, 3, -4, 5, 2 }));
    }
    public static int AdjacentElementsProduct(int[] intArray)
    {
        int max = intArray[0] * intArray[1];
        for (int i = 1; i <= intArray.Length - 2; i++) // my mistake was: (int i = 1; i < intArray.Length - 2; i++) then it ignored last iteration... false result
        {
            Console.WriteLine("=> " + intArray[i] * intArray[i + 1] + "\n");
            max = Math.Max(max, (intArray[i] * intArray[i + 1]));
        }
        return max;
    }

    /**
    * Write a C# program that accepts a list of integers and checks how many integers are needed to complete the range. 
    * Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list. So output will be 4.
    * 
    * MAIN TAKEAWAY:
    * Array.Sort(nameOfArray) => It's a *STATIC* method of the class Array
    * 
    * 
   **/
    public static void Basic58()
    {
        Console.WriteLine(ConsecutiveArray(new int[] { 1, 3, 5, 6, 9 }));
        Console.WriteLine(ConsecutiveArray(new int[] { 0, 10 }));
    }
    public static int ConsecutiveArray(int[] array)
    {
        Array.Sort(array); // By default sorts ascending. It's a STATIC method! 
        int counter = 0;
        for (int i = 0; i < array.Length - 1; i++) 
        {
            counter += array[i + 1] - array[i] - 1; 
        }
        return counter;
    }

    /**
    * Bonus example: 
    *  Imagine you need to manage inventory and process customer orders. Each product in your inventory has a unique product ID, and customer orders are associated with these IDs. 
    *  Your goal is to ensure that all products in your inventory have a corresponding order and vice versa. 
    *  Any missing product IDs or order numbers could lead to issues such as unfulfilled orders or inventory discrepancies.
    * 
   **/
    public static List<int> FindMissingProductIDs(List<int> inventory, List<int> orders)
    {
        // Create a list to store missing product IDs
        List<int> missingProductIDs = new List<int>();

        // Sort the inventory and orders lists
        inventory.Sort();
        orders.Sort();

        // Initialize index variables for both lists
        int inventoryIndex = 0;
        int orderIndex = 0;

        // Compare product IDs in the inventory and orders
        while (inventoryIndex < inventory.Count && orderIndex < orders.Count)
        {
            int inventoryID = inventory[inventoryIndex];
            int orderID = orders[orderIndex];

            if (inventoryID == orderID)
            {
                // Product ID is found in both inventory and orders
                inventoryIndex++;
                orderIndex++;
            }
            else if (inventoryID < orderID)
            {
                // Product ID is missing in orders
                missingProductIDs.Add(inventoryID);
                inventoryIndex++;
            }
            else
            {
                // Product ID is missing in inventory
                orderIndex++;
            }
        }

        // Add any remaining missing product IDs from the inventory
        while (inventoryIndex < inventory.Count)
        {
            missingProductIDs.Add(inventory[inventoryIndex]);
            inventoryIndex++;
        }

        return missingProductIDs;
    }

    public static void Basic588()
    {
        List<int> inventory = new List<int> { 101, 102, 104, 105 };
        List<int> orders = new List<int> { 101, 103, 105 };

        List<int> missingProductIDs = FindMissingProductIDs(inventory, orders);

        Console.WriteLine("Missing Product IDs in Orders: ");
        foreach (int productID in missingProductIDs)
        {
            Console.WriteLine(productID);
        }
    }

    /**
    * Check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array
    * 
    * MAIN TAKEAWAY: My attempt.
    * 
    **/
    public static bool IsIncreasingSequence(int[] array)
    {
        Array.Sort(array);
        for (int i = 0; i < array.Length - 1; i++)
        {
            int diff = array[i + 1] - array[i];

            if(diff <= 0)
            {
                return false;
            }
        }
        return true;
    }
    public static void Basic59()
    {
        Console.WriteLine(IsIncreasingSequence(new int[] { 2, 3, 5, 2}));
        Console.WriteLine(IsIncreasingSequence(new int[] { 7, 3, 5, 12}));
    }

    /**
    * sum the matrix elements column-wise until a non-positive value is encountered
    * Sample Example:
        matrix = [[0, 2, 3, 2],
                  [0, 6, 0, 1],
                  [4, 0, 3, 0]]
    Eligible integers which will be participated to calculate the sum -
       matrix = [[X, 2, 3, 2],
                 [X, 6, X, 1],
                 [X, X, X, X]]
    Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
    * 
    * My FAILED attempt
    * 
    **/
    public static int SumMatrixElements(int[][] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    continue;
                }
                else
                {
                    sum += matrix[i][j];
                }
            }
        }
        return sum;
    }
    public static void Basic60()
    {
        Console.WriteLine(SumMatrixElements(
            new int[][]
            {
                new int[] { 0, 2, 3, 2},
                new int[] { 0, 6, 0, 1},
                new int[] { 4, 0, 3, 0}
            }));
        Console.WriteLine(SumMatrixElements(
            new int[][]
            {
                new int[] { 1, 2, 1, 0},
                new int[] { 0, 5, 0, 0},
                new int[] { 1, 1, 3, 10 }
            }));
    }

    /**
     * Correction
     * MAIN TAKEAWAY: Don't hesistate to add more conditions inside a for loop!
     * iterating [i][j] => ROW-WISE
     * iterating [j][i] => COLUMN-WISE 
     */
    public static int SumMatrixElements2(int[][] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix[0].Length; i++) // We are assuming that all sub-arrays are the same length
        {
            for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++) // && condition inside the for loop
            {
                sum += matrix[j][i]; // This way we are doing our sum column-wise
            }
        }
        return sum;
    }
    public static void Basic600()
    {
        Console.WriteLine(SumMatrixElements2(
            new int[][]
            {
                new int[] { 0, 2, 3, 2},
                new int[] { 0, 6, 0, 1},
                new int[] { 4, 0, 3, 0}
            }));
        Console.WriteLine(SumMatrixElements2(
            new int[][]
            {
                new int[] { 1, 2, 1, 0},
                new int[] { 0, 5, 0, 0},
                new int[] { 1, 1, 3, 10 }
            }));
    }

    /**
    * 
    * 
    * MAIN TAKEAWAY:
    * 
    **/
    public static void BasicXX()
    {

    }

}