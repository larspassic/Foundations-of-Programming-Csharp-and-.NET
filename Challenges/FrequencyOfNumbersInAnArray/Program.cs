using System;

namespace FrequencyOfNumbersInAnArray
{

    class Stack //Create a Stack class to use in the program
    {
        private int[] stack = new int[10];
        private int sp = 0;

        public void Push (int v)
        {
            if (sp == stack.Length) //Check if we need to grow the stack
            {
                int[] newArray = new int[stack.Length * 2];
                for (int x=0; x<stack.Length; x++)
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

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {

                var stack = new Stack();

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
                    stack.Push(userInputInt);

                }


            }
        }
    }
}
