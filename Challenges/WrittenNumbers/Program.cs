using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenNumbers
{
    class Program
    {
        /// <summary>
        /// Write a program that, given an amount prints the appropriate text. 
        /// For example:
        /// 1234
        /// 1 thousand 2 hundred 34 Dollasssss
        /// 4580.34 would print "4 Thousand 5 hundred 80 Dollars and 34 cents"
        /// </summary>
        /// <param name="args"></param>
        /// 

        static void Main(string[] args)
        {
            while (true)
            {
                //Give instructions to users                
                Console.WriteLine("Enter a number, and it will be written out using words (like when writing a check):");

                //Collect input as a string
                string userInput = Console.ReadLine();

                /**This is the start of how RJ did the cents portion **/


                //Multiple the user input by 100. This will bring whatever is in the "Cents" portion of the value
                //to the left of the decimal. IE 1234.12 would result in 123412.00
                float userInputAsFloat = float.Parse(userInput) * 100;
                //Since we moved the decimal values to the left we simply need to mod by 100 to get what was in the "cents" portion.
                // IE 123412 % 100 = 12. We cast to integer because we don't need anything after
                int actualCents = (int)userInputAsFloat % 100;
                Console.WriteLine(actualCents);



                //Parse input as double
                double userInputNumber = double.Parse(userInput);

                //Calculate cents (Lars version)
                //double cents = userInputNumber * 100;
                //cents = cents % 100;

                //Make a new version of cents to have a decimal point
                decimal dotCents = (decimal)actualCents / 100;

                //Simplify userInputNumber by removing cents
                userInputNumber = userInputNumber - dotCents;

                //Caclulate tens
                double tens = userInputNumber % 100;

                //Calculate hundreds
                double hundreds = userInputNumber % 1000;

                //Calculate thousands
                double thousands = userInputNumber % 10000;

                //Simplify thousands by removing hundreds
                thousands = thousands - hundreds;
                //Reduce thousands
                thousands = thousands / 1000;

                //Simplify hundreds by removing tens
                hundreds = hundreds - tens;
                //Reduce hundreds
                hundreds = hundreds / 100;


                //Write output to the user
                string finalString = "";

                //Don't write thousands if there aren't any
                if (thousands > 0)
                {
                    finalString = $"{thousands} thousand ";
                }
                //Don't write hundreds if there aren't any
                if (hundreds > 0)
                {
                    finalString = finalString + ($"{hundreds} hundred ");
                }
                //Don't write tens if there aren't any
                if (tens > 0)
                {
                    finalString = finalString + ($"{tens} ");
                }
                //Only write the word dollars if any of the three dollar results are at least greater than zero
                if (thousands > 0 || hundreds > 0 || tens > 0)
                {
                    finalString = finalString + "dollars ";
                }
                //If there has been nothing thus far, no need to write and
                if (finalString != "")
                {
                    finalString = finalString + ($"and ");
                }
                //Always write cents even if zero, just like on a check
                finalString = finalString + ($"{actualCents} cents.");
                Console.WriteLine(finalString);
                Console.WriteLine();

            }
        }

    }
}
