using System;

namespace IsAStringAPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Instructions to user for input
                Console.Write("Please enter a string, and the program will tell you if it is a palindrome! (for example AVA):");

                //Receive input from user as a string
                string userInput = Console.ReadLine();

                //Loop to reverse the string
                string reversedString = "";
                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    reversedString += userInput[i];
                }

                bool result = userInput.Equals(reversedString);

                //Output to user
                Console.WriteLine($"The string you entered was {userInput}");
                Console.WriteLine($"The reverse of the string is {reversedString}");
                Console.WriteLine($"The string you entered is {(result ? "a palindrome" : "not a palindrome")}.\n");
            }
        }
    }
}
