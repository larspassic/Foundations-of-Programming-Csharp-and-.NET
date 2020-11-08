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

                //Calculate cents
                double cents = userInputNumber * 100;
                cents = cents % 100;

                //Simplify userInputNumber by removing cents
                userInputNumber = userInputNumber - (cents / 100);

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
                
                if (thousands > 0)
                {
                    finalString = $"{thousands} thousand ";
                }
                if (hundreds > 0)
                {
                    finalString = finalString + ($"{hundreds} hundred ");
                }
                if (tens > 0)
                {
                    finalString = finalString + ($"{tens} ");
                }
                if (thousands > 0 || hundreds > 0 || tens > 0)
                {
                    finalString = finalString + "dollars ";
                }

                finalString = finalString + ($"and {cents} cents.");
                Console.WriteLine(finalString);
                Console.WriteLine();

            }
        }
	
    }
}
