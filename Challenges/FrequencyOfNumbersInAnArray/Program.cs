using System;

namespace FrequencyOfNumbersInAnArray
{
    class NumberObject //Create a NumberObject class to store the counts of numbers in the array
    {
        public string NumberName;
        public int NumberCount;
    }

    class Stack //Create a Stack class to use in the program
    {
        private int[] stack = new int[10];
        private int sp = 0;

        public void Push (int v)
        {
            if (sp == stack.Length) //Check if we need to grow the stack
            {
                int[] newArray = new int[stack.Length * 2];
                for (int x = 0; x < stack.Length; x++)
                {
                    newArray[x] = stack[x];
                }
                stack = newArray;
            }
            stack[sp++] = v;

        }

        public int Pop()
        {
            return stack[--sp];
        }

        public int Top
        {
            get
            {
                return stack[sp - 1];
            }

        }

        public bool IsEmpty
        {
            get
            {
                return sp == 0;
            }
        }

        public int Length
        {
            get
            {
                return stack.Length;
            }
        }

        public string Written
        {
            get
            {
                string writtenStack = "";
                for (int x = 0; x < sp; x++)
                {
                    writtenStack += stack[x];
                    if (x < sp - 1)
                    {
                        writtenStack += ", ";
                    }
                    
                }
                return writtenStack;
            }
        }

    }


    
    class Program //Main area of the program
    {
        static void Main(string[] args)
        {
            //Create the main array of numbers to store the number objects
            var numberArray = new NumberObject[100];

            while (true)
            {

                var stack = new Stack();

                while (true) //Input loop to build a stack/array of numbers
                {
                    
                    
                    //Ask the user to build an array of numbers
                    Console.WriteLine("Enter one integer (whole) number at a time, (between 0 and 100), or press enter to continue:");

                    string userInput = Console.ReadLine();

                    if (userInput == "") //User will press enter to break out of the input loop
                    {
                        break;
                    }

                    int userInputInt = int.Parse(userInput);
                    stack.Push(userInputInt);

                }

                //User broke out of the input loop
                Console.WriteLine("Now the program will determine the frequency of numbers in the array you created.");

                //Pop the number off the stack
                for (int i=1; i<stack.Length; i++)
                {
                    string letter = stack[i];

                }

                //Output what the user has so far
                Console.WriteLine($"The array you created was {stack.Written}");

                //Loop through the entire numberArray object to show the results

                //Do the calculation to figure out frequency

            }
        }
    }
}
