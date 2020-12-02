using System;

class Program
{
    static void Main()
    {
        var x = 11;
        var y = 22;

        Swap(ref x, ref y);

        Console.WriteLine("X={0} started as 11, after swap should be 22", x);
        Console.WriteLine("Y={0} started as 22, after swap should be 11", y);
        Console.ReadLine();
    }

    // Write the Swap method so that
    // the two values passed in are swapped.
    static void Swap(ref int first, ref int second)
    {
        //Create a temp variable, and store a copy of the first variable
        var temp = first;

        //Do the actual swap by copying second in to first
        first = second;

        //Move the contents of temp back in to the second variable
        second = temp;
    }
}