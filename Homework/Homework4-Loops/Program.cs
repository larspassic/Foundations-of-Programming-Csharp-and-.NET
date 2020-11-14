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
                //Changing from a while loop to a for loop
                for (Int64 loopIterator = (factorialIterator - 1) ; loopIterator > 0; loopIterator--)
                {
                    //Decrement the iterator early, so the math will be correct for the factorial calculation
                    factorialIterator--;

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
