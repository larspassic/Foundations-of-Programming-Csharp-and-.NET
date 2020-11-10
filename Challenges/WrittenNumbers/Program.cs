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

                //Parse input as double
                double userInputNumber = double.Parse(userInput);

                //Gutting the old logic because it wasn't working and wasn't good in the 10,000 numbers

                //Mod 1 returns cents
                //double cents = userInputNumber % 1;
                int cents = (int)(userInputNumber * 100) % 100;
                int cleanCents = (int)(cents * 100);

                //Mod 100 returns the remainder of (userInputNumber / 100) which is tens and cents
                double leftoverTens = userInputNumber % 100;
                //So remove the cents which will make a straightforward tens number
                double tens = leftoverTens - cents;

                //Mod 1000 returns the remainder of (userInputNumber / 1000) which is hundreds, tens, and cents
                double leftoverHundreds = userInputNumber % 1000;
                //So remove the tens and the cents and you have a clean hundreds number
                double hundreds = leftoverHundreds - tens - cents;
                hundreds = hundreds / 100;

                //We already have the remainder of of hundreds, tens and cents, so remove that will leave us with thousands and above
                double thousands = userInputNumber - leftoverHundreds;
                //Divide by 1000 to get number of thousands
                thousands = thousands / 1000;




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
                finalString = finalString + ($"{cleanCents} cents.");
                Console.WriteLine(finalString);
                Console.WriteLine();

            }
        }

    }
}
