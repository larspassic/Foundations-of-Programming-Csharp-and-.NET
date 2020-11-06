using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvertimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Ask the user for hours worked this week
                Console.Write("Please enter the number of hours worked this week:");

                //Collect the number of hours from the user
                string strUserInputHours = Console.ReadLine();

                //Ask the user for hourly wage
                Console.Write("Please enter the regular hourly rate:");

                //Collect the regular hourly rate from the user
                string strUserInputRate = Console.ReadLine();

                //Convert the hours string input to an int
                float floatUserInputHours = float.Parse(strUserInputHours);

                //Convert the rate string input to an int
                float floatUserInputRate = float.Parse(strUserInputRate);

                //Create a variable to hold regular hours
                float regularHours = 0;
                //Create a variable to hold overtime hours
                float overtimeHours = 0;
                //Create a variable to hold regular pay
                float regularPay = 0;
                //Create a variable to hold overtime pay
                float overtimePay = 0;
                //Create a variable to hold total weekly pay
                float totalPay = 0;

                //If hours is less than 40, go ahead and calculate it
                if (floatUserInputHours <= 40)
                {
                    totalPay = floatUserInputHours * floatUserInputRate;
                }
                //Else if hours is more than 40, separate into regular and overtime
                else
                {
                    //Separate the hours in to regular and overtime
                    regularHours = 40;
                    overtimeHours = floatUserInputHours - 40;

                    /*Calculate pay for the regular work week
                    regularPay = (regularHours * floatUserInputRate);

                    //Change the rate to get ready for overtime
                    floatUserInputRate = floatUserInputRate * (float)1.5;
                    
                    //Calculate pay for the overtime
                    overtimePay = overtimeHours * floatUserInputRate;

                    //Combine regular and overtime for full week pay
                    totalPay = regularPay + overtimePay;
                    */

                    //Trying a more condensed calculation (why do I need to cast the 1.5 as a float????
                    totalPay = (regularHours * floatUserInputRate) + (overtimeHours * (floatUserInputRate * (float)1.5));
                }

                //Write output to the user
                Console.WriteLine($"For {floatUserInputHours} hours at ${floatUserInputRate} base rate, your weekly earnings was ${totalPay}");
                Console.WriteLine();

            }

        }
    }
}
