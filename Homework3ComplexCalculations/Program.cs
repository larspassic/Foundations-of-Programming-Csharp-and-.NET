using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3ComplexCalculations
{
    //Create an enum of the numbers of seconds
    enum eNumberOfSeconds
    {
        SecondsPerDay = 86400,
        SecondsPerHour = 3600,
        SecondsPerMinute = 60,
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Keep the program going continually
            while (true)
            {

                //Provide instructions at the command line
                Console.Write("Please enter a number of seconds:");

                //Declare the variable to hold the number of seconds
                int secondsInputInt = 0;

                //Collect input from the user as a string
                string secondsInputString = Console.ReadLine();

                //Parse from string input to integer
                secondsInputInt = int.Parse(secondsInputString);

                //Establish the variables to store the results of the computation
                int computedDays = 0;
                int computedHours = 0;
                int computedMinutes = 0;
                int computedSeconds = 0;
                int leftoverSeconds = 0;

                //Calculate number of days
                computedDays = secondsInputInt / (int)eNumberOfSeconds.SecondsPerDay;
                leftoverSeconds = secondsInputInt % (int)eNumberOfSeconds.SecondsPerDay;

                //Calculate nubmer of hours if there were leftover seconds from days calculation
                if (leftoverSeconds > 0)
                {
                    computedHours = leftoverSeconds / (int)eNumberOfSeconds.SecondsPerHour;
                    leftoverSeconds = leftoverSeconds % (int)eNumberOfSeconds.SecondsPerHour;
                }

                //Calculate number of minutes if there were leftover seconds from hours calculation
                if (leftoverSeconds > 0)
                {
                    computedMinutes = leftoverSeconds / (int)eNumberOfSeconds.SecondsPerMinute;
                    leftoverSeconds = leftoverSeconds % (int)eNumberOfSeconds.SecondsPerMinute;
                }
                
                //Assign any leftover seconds to the computed seconds which will display to the user
                if (leftoverSeconds > 0)
                {
                    computedSeconds = leftoverSeconds;
                }

                //Display output to the user
                Console.WriteLine("{4} seconds is {0} days, {1} hours, {2} minutes, {3} seconds", computedDays, computedHours, computedMinutes, computedSeconds, secondsInputInt);
                Console.WriteLine();
            }
        }
    }
}
