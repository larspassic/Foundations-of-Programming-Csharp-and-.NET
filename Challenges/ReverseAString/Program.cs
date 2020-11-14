using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Provide instructions to the user
                Console.Write("Please enter a word or number, and the program will reverse it!");

                //Receive input from the user as a string
                string userInput = Console.ReadLine();

                //Create an array with chars?
                char[] charArray = new char[userInput.Length];

                //loop to store the chars from the userInput string as array elements
                int count = 0;
                foreach (char charElement in userInput)
                {
                    charArray[count] = userInput[count];
                    count++;
                }

                //Another loop to reverse the array
                char[] reverseArray = new char[charArray.Length];
                count = 0;
                int reverseCount = charArray.Length - 1;
                foreach (char charElement in charArray)
                {
                    reverseArray[count] = charArray[reverseCount];
                    count++;
                    reverseCount--;
                }

                //Put the chars back into a new string
                string reversedString = "";
                count = 0;
                foreach (char charElement in reverseArray)
                {
                    reversedString = reversedString + reverseArray[count];
                    count++;
                }

                //Display the results to the user
                Console.WriteLine($"{reversedString}");
                Console.WriteLine();
            }
        }
    }
}
