using System;

class Program
{
    static void Main()
    {
        bool validEntry = false;
        
        while (!validEntry)
        {

            Console.Write("Check Number: ");
            string checkNumber = Console.ReadLine();

            try
            {
                Console.WriteLine("You entered check #{0}", int.Parse(checkNumber));
            }
            catch (FormatException formatException) //More specific exception needs to come first
            {
                Console.WriteLine($"Message: {formatException.Message}\nStack Trace: {formatException.StackTrace}");
            }
            catch (Exception) //More general exception needs to come last
            {
                Console.WriteLine($"You entered {checkNumber} but that was not valid input. Try again.");
            }
        }
        validEntry = false;
        while (!validEntry) //Second approach
        {
            Console.Write("Check Number: ");
            string input = Console.ReadLine();

            int checkNumber;

            if (!int.TryParse(input, out checkNumber))
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            Console.WriteLine($"You entered check #{checkNumber}");
            validEntry = true;
        }
        Console.ReadLine();
    }
}