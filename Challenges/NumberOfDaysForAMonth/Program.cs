using System;

namespace NumberOfDaysForAMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Create an int to hold the input
                string inputMonth;

                //Ask the user for a month number
                Console.WriteLine("Input the number of a month (1-12)");

                //Get the input from the user and save it in to a string type
                inputMonth = Console.ReadLine();

                //Parse from string to integer
                int monthInt = int.Parse(inputMonth);

                //Switch variable
                int caseSwitch = monthInt;

                //Switch statement for months
                switch (caseSwitch)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("The month you entered has 31 days");
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("The month you entered has 30 days");
                        break;
                    case 2:
                        Console.WriteLine("The month you entered has 28 or 29 days");
                        break;
                    default:
                        Console.WriteLine("The number you entered must not have been 1 - 12. Please try again.");
                        break;

                }
            }

        }
    }
}
