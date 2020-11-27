﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToLowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Ask the user to enter a string
                Console.Write("Please enter a string, and the program will convert it to lowercase:");

                //Collect input as a string
                string strUserInput = Console.ReadLine();

                //Loop to put the chars into an char array
                int[] intArray = new int[strUserInput.Length];
                decimal[] decArray = new decimal[intArray.Length];
                //Hopefully converting to an int will result in unicode value
                for (int i=0; i < strUserInput.Length; i++)
                {
                    intArray[i] = strUserInput[i];
                    decArray[i] = strUserInput[i];
                }


                //Loop to subtract 20 from the unicode number, which will result in the lowercase version of the unicode character, and populate a new char array
                char[] charArray = new char[intArray.Length];
                
                for (int i=0; i < intArray.Length; i++)
                {

                    charArray[i] = (char)(intArray[i]);
                    
                }

                //Loop to build a final string from the new char array
                string strFinalString = new String(charArray); //Cheating? maybe not...
                /*
                string strFinalString = "";

                for (int i = 0; i < charArray.Length; i++)
                {

                    strFinalString = strFinalString + charArray[i];

                }
                */

                //Output the final string to the user
                Console.WriteLine($"Your string converted to lowercase is {strFinalString}");
            }
        }
    }
}
