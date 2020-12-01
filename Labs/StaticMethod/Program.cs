using System;

class Sorter
{
    public static void BubbleSort(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            for (int inner = index; inner < array.Length; inner++)
            {
                if (array[index] > array[inner])
                {
                    Swap(ref array[index], ref array[inner]);
                }
            }
        }
    }

    private static void Swap(ref int first, ref int second)
    {
        var temp = first;
        first = second;
        second = temp;
    }

    // TODO: Add static Print function
    public static void Print(string title, int[] intArray)
    {
        //First print the title that was sent over in the string
        Console.Write($"{title}");

        //Create a loop to go through the array and write each item out
        foreach (var item in intArray)
        {
            Console.Write($"{item}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        var values = new int[] { 5, 4, 3, 2, 1 };

        Sorter.Print("Not sorted: ", values);
        Sorter.BubbleSort(values);
        Sorter.Print("Sorted: ", values);

        Console.ReadLine();
    }
}