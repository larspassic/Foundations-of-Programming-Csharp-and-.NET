using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 15, 22, 71, 72, 78, 81, 82, 83, 84, 85, 86, 90, 91, 92, 95, 94 };

        // What should the default value be?
        bool isAscending = false;

        int firstNumber = 0;
        int secondNumber = 0;

        //loop through the numbers array
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            // How do you know if it is ascending?
            firstNumber = numbers[i];
            secondNumber = numbers[i + 1];

            if (secondNumber > firstNumber)
            {
                isAscending = true;
            }
            else
            {
                isAscending = false;
            }

            if (isAscending == false)
            {
                break;
            }

        }
        string strNumbers = "";

        for (int x = 0; x < numbers.Length; x++)
        {
            strNumbers += numbers[x];
            if (x < numbers.Length - 1)
            {
                strNumbers += ",";
            }
        }
        Console.WriteLine($"{strNumbers}");
        Console.WriteLine($"The array is ascending: {isAscending}");

        Console.ReadLine();
    }
}