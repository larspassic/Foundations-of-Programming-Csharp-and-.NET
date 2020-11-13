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
        /// 4580.34 would print "4 Thousand 5 hundred 80 Dollars and 34 cents"
        /// </summary>
        /// <param name="args"></param>
        /// 

        static void Main(string[] args)
        {
            while (true)
            {
                //Give instructions to users
                Console.Write("Enter a number, and it will be written out:");

                //Collect input as a string
                string userInput = Console.ReadLine();

                //Parse input as double
                decimal userInputNumber = decimal.Parse(userInput);

                //Mod 1 returns cents
                decimal cents = userInputNumber % 1;

                //Mod 100 returns the remainder of (userInputNumber / 100) which is tens and cents
                decimal leftoverTens = userInputNumber % 100;
                //So remove the cents which will make a straightforward tens number
                decimal tens = leftoverTens - cents;

                //Mod 1000 returns the remainder of (userInputNumber / 1000) which is hundreds, tens, and cents
                decimal leftoverHundreds = userInputNumber % 1000;
                //So remove the tens and the cents and you have a clean hundreds number
                decimal hundreds = leftoverHundreds - tens - cents;
                hundreds = hundreds / 100;

                //We already have the remainder of of hundreds, tens and cents, so remove that will leave us with thousands and above
                decimal thousands = userInputNumber - leftoverHundreds;
                //Divide by 1000 to get number of thousands
                thousands = thousands / 1000;

                //Format output to get ready to present to user
                string finalString = "";
                if (cents > 0) 
                {
                    cents = cents * 100;
                }
                string centsString = cents.ToString("0");
                string tensString = tens.ToString("#");
                string hundredsString = hundreds.ToString("#");
                string thousandsString = thousands.ToString("#");

                //Begin building string to present to the user
                //Don't write thousands if there aren't any
                if (thousands > 0)
                {
                    finalString = $"{thousandsString} thousand ";
                }
                //Don't write hundreds if there aren't any
                if (hundreds > 0)
                {
                    finalString = finalString + ($"{hundredsString} hundred ");
                }
                //Don't write tens if there aren't any
                if (tens > 0)
                {
                    finalString = finalString + ($"{tensString} ");
                }
                //Only write the word dollars if any of the three dollar results are at least greater than zero
                if (thousands > 0 || hundreds > 0 || tens > 0)
                {
                    finalString = finalString + "dollars ";
                }
                //If there has been nothing thus far, no need to write 'and'
                if (finalString != "")
                {
                    finalString = finalString + ($"and ");
                }
                //Always write cents even if zero, just like on a check
                finalString = finalString + ($"{centsString} cents.");
                Console.WriteLine(finalString);
                Console.WriteLine();
            }
        }
    }
}
