using System;

namespace FrequencyOfNumbersInAnArray
{

    class Stack
    {
        int[] stackInt = new int[10];

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                                
                int[] stack = new int[10];

                while (true)
                {
                    
                    
                    //Ask the user to build an array of numbers
                    Console.WriteLine("Enter an integer (whole) number between 0 and 100, or press enter to continue:");

                    string userInput = Console.ReadLine();

                    if (userInput == null)
                    {
                        break;
                    }

                    int userInputInt = int.Parse(userInput);


                }


            }
        }
    }
}
