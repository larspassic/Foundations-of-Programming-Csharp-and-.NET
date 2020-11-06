// Ask user to input a month number 1, or 2, or 3 for (Jan, Feb, and Mar).
// Then check how many days each month has (say 31, 29, 30 days for each).
// Print the month and the number of days to screen.
// Finish the rest of exercise on your own and include all the months of the year.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {

            string monthNumber;

            Console.Write("Please enter a month number (1 to 12): ");
            monthNumber = Console.ReadLine();

            string month = "";
            int daysOfTheMonth = 0;

            switch (monthNumber)
            {
                case "1":
                    daysOfTheMonth = 31;
                    month = "January";
                    break;
                case "2":
                    daysOfTheMonth = 28;
                    month = "February";
                    break;
                case "3":
                    daysOfTheMonth = 31;
                    month = "March";
                    break;
                // code here
                case "4":
                    daysOfTheMonth = 30;
                    month = "April";
                    break;
                case "5":
                    daysOfTheMonth = 31;
                    month = "May";
                    break;
                case "6":
                    daysOfTheMonth = 30;
                    month = "June";
                    break;
                case "7":
                    daysOfTheMonth = 31;
                    month = "July";
                    break;
                case "8":
                    daysOfTheMonth = 31;
                    month = "August";
                    break;
                case "9":
                    daysOfTheMonth = 30;
                    month = "September";
                    break;
                case "10":
                    daysOfTheMonth = 31;
                    month = "October";
                    break;
                case "11":
                    daysOfTheMonth = 30;
                    month = "November";
                    break;
                case "12":
                    daysOfTheMonth = 31;
                    month = "December";
                    break;

                // continue the code up to case "12", December
                default:
                    Console.WriteLine("You must not have entered a month number between 1 and 12. Please try again.");
                    break;
            }

            Console.WriteLine("The month {0} has {1} days", month, daysOfTheMonth);
            //Console.ReadLine();
        }
    }
}