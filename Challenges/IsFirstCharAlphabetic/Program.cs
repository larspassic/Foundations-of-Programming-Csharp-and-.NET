using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsFirstCharAlphabetic
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Give instructions to the user
                Console.Write("Please enter a word, and we will tell you if the first character is alphabetic:");

                //Gather input from the user
                string userInput = Console.ReadLine();

                //Grab only the first character from the user input and store it as a char
                char charVariable = userInput[0];

                //Figure out if the char is a number or not
                bool charOutput = char.IsNumber(charVariable);

                //Explain to the user that the first character was a number
                if (charOutput == true)
                {
                    Console.WriteLine("The first character of your entry({0}) was a number!", charVariable);
                }
                //Explain to the user that the first character was a letter
                else
                {
                    Console.WriteLine("The first character of your entry({0}) was a letter!", charVariable);
                }
                Console.WriteLine();

            }
        }
    }
}
