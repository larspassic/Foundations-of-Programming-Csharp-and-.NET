// Create a program that determines the number of days for a month using a switch statement. 
// The program should accept the number of the month in question.
using System;

enum eMonthNames
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December,
}
enum eMonthDays
{
    January = 30,
    February = 29,
    March = 31,
    April = 31,
    May = 30,
    June = 31,
    July = 31,
    August = 31,
    September = 31,
    October = 31,
    November = 31,
    December = 31,

}

class Program
{

    static void Main()
    {
        while (true)
        {
            eMonthNames eName;

            Console.Write("Please enter a Month Number: ");
            string monthNumber = Console.ReadLine();

            int nDays = 0;

            switch (monthNumber)
            {
                case "1":
                    eName = eMonthNames.January;
                    nDays = (int)eMonthDays.January;
                    break;
                case "2":
                    // TO DO
                    eName = eMonthNames.February;
                    nDays = (int)eMonthDays.February;
                    break;


                case "3":
                    // TO DO
                    eName = eMonthNames.March;
                    nDays = (int)eMonthDays.March;
                    break;

                case "4":
                    // TO DO
                    eName = eMonthNames.April;
                    nDays = (int)eMonthDays.April;
                    break;

                case "5":
                    // TO DO
                    eName = eMonthNames.May;
                    nDays = (int)eMonthDays.May;
                    break;
                case "6":
                    // TO DO
                    eName = eMonthNames.June;
                    nDays = (int)eMonthDays.June;
                    break;

                case "7":
                    // TO DO
                    eName = eMonthNames.July;
                    nDays = (int)eMonthDays.July;
                    break;
                case "8":
                    // TO DO
                    eName = eMonthNames.August;
                    nDays = (int)eMonthDays.August;
                    break;
                case "9":
                    // TO DO
                    eName = eMonthNames.September;
                    nDays = (int)eMonthDays.September;
                    break;
                case "10":
                    // TO DO
                    eName = eMonthNames.October;
                    nDays = (int)eMonthDays.October;
                    break;
                case "11":
                    // TO DO
                    eName = eMonthNames.November;
                    nDays = (int)eMonthDays.November;
                    break;
                case "12":
                    // TO DO
                    eName = eMonthNames.December;
                    nDays = (int)eMonthDays.December;
                    break;

                    default:
                    eName = eMonthNames.December;
                    nDays = (int)eMonthDays.December;

                    break;
            }
            Console.WriteLine("Month {0} has {1} days\n\n", eName, nDays);
        }
    }
}