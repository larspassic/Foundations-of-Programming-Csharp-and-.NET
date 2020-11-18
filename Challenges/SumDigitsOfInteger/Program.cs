using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Ask the user for input
                Console.Write("Please enter an integer, and the program will sum the digits:");

                //Take the input from the user as a string
                string strUserInput = Console.ReadLine();

                //Parse the string in to an int
                int intUserInput = int.Parse(strUserInput);

                int sumTotal = 0;

                //Loop through the elements in the user input
                foreach (int element in intUserInput)
                {
                    Console.WriteLine($"Processing {element}");
                    sumTotal = sumTotal + element;
                }

                //Display result to user
                Console.WriteLine($"The sum of all of the digits in your input ({strUserInput}) is {sumTotal}");
                Console.WriteLine();
            }
        }
    }
}
