using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Give instructions to the user
                Console.Write("Please enter an integer:");

                //Collect input from the user as a string
                string userInput = Console.ReadLine();

                //Store the input as a large integer
                Int64 userInputInt = Int64.Parse(userInput);

                //Set up the factorial iterator
                Int64 factorialIterator = userInputInt;

                //Set up the variable to store the result
                Int64 factorialResult = factorialIterator;

                //Write a loop to calculate the factorial
                /* Commented out to work on the for loop
                while (factorialIterator > 0)
                {
                    //Decrement the iterator early, so it can be used in the factorial calculation
                    factorialIterator--;

                    //Check for "divide by zero" event
                    if (factorialIterator > 0)
                    {
                        //Perform the actual factorial calculation
                        factorialResult = factorialResult * factorialIterator;
                    }

                }
                */

                //Changing from a while loop to a for loop
                for (Int64 loopIterator = factorialIterator; loopIterator > 0; loopIterator--)
                {
                    //Check for "divide by zero" event
                    if (loopIterator > 0)
                    {
                        factorialResult = factorialResult * factorialIterator;
                    }

                }

                //Display the results to the user
                Console.WriteLine("{0}! = {1}", userInputInt, factorialResult);
                
                Console.WriteLine();
            }
        }
    }
}
