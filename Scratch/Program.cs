// Create an array of numbers and find the max and min values of your array

using System;

class Program
{
    static void Main()
    {

        // start with the given array
        int[] numbers = new int[] { 0, 2, 5, 100, -1, 4, 8, -5 };


        // define the max and min
        int smallestNumber = 0;
        int largestNumber = 0;

        foreach (int x in numbers)
        {
            if (x < smallestNumber)
            {
                smallestNumber = x;
            }
            if (x > largestNumber)
            {
                largestNumber = x;
            }
        }

        Console.WriteLine("The Minimum value is {0}", smallestNumber);
        Console.WriteLine("The Maximum value is {0}", largestNumber);

        Console.ReadLine();
    }
}