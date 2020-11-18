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

                //Create the variable to hold the output sum
                int sumTotal = 0;

                //Create array of ints
                int[] intArray = new int[strUserInput.Length];

                //Loop to populate the int array
                for (int loopCount = 0; loopCount < strUserInput.Length; loopCount++)
                {
                    //string tempString = (int)strUserInput[loopCount];
                    int tempVar = (int)char.GetNumericValue(strUserInput[loopCount]);
                    intArray[loopCount] = tempVar;
                }

                //Loop through the elements in the user input
                foreach (int element in intArray)
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
