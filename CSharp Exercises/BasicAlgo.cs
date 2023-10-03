using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class BasicAlgo
{
    /*
    check two integers and return the value nearest to 13 without crossing over. Return 0 if both numbers exceed.
    */
    public static void BasicAlgo58()
    {
        Console.WriteLine(test58(4, 5));
        Console.WriteLine(test58(7, 12));
        Console.WriteLine(test58(10, 13));
        Console.WriteLine(test58(17, 33));
        Console.ReadLine();
    }
    public static int test58(int x, int y)
    {
        if (x > 13 && y > 13) return 0;    
        if (x <= 13 && y > 13) return x;    
        if (y <= 13 && x > 13) return y;
        return x > y ? x : y;

    }

    /*
    compare three integers (small, medium, and large) 
    return true if the difference between small and medium and the difference between medium and large is the same.
    4, 5, 6 -> true

    Personal attempt, inspired by Basic exercises but without array & sort() to ascending order
    */
    public static void BasicAlgo59()
    {
        Console.WriteLine(test59(4, 5, 6));
        Console.WriteLine(test59(7, 12, 13));
        Console.WriteLine(test59(-1, 0, 1));
        Console.ReadLine();
    }
    public static bool test59(int x, int y, int z)
    {
        int diff1 = Math.Abs(y - x);
        int diff2 = Math.Abs(z - y);   

        if (diff1 == diff2) return true;
        return false;
    }

    /*
     rotate the elements of a given array of integers in left direction and return the new array
    MY ATTEMPT
    Main takeaway: Array size cannot be dynamically changed in Csharp! that would be lists
    */
    public static void BasicAlgo90()
    {
        int[] newArray = test90(new[] { 10, 20, -30, -40 });
        foreach (int num in newArray)
        {
            Console.WriteLine(num);
        }
    }
    public static int[] test90(int[] array)
    {
        int[] reversedArray = new int[array.Length]; // initially hard coded the length!

        for (int i = 0; i <= array.Length - 1; i++)
        {
            if(i == array.Length - 1)
            {
                reversedArray[i] = array[0];
                return reversedArray; // Initially wanted a break statement here... Just use return!
            }
            reversedArray[i] = array[i + 1];
        }
        return reversedArray;
    }
    /*
     Actual 'solution':
     public static int[]  test(int[] a1)
          {
             return new int[] { a1[1], a1[2], a1[3], a1[0] };
          } 
    */

    /*

    */
    public static void BasicAlgoXX()
    {

    }
    public static void testXX()
    {

    }
}
