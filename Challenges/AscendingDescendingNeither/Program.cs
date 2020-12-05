using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 15, 22, 71, 72, 78, 81, 82, 83, 84, 85, 86, 90, 91, 92, 95, 94 };

        // What should the default value be?
        bool isSequential = false;
        string strAscendingOrDescending = "";

        int firstNumber = 0;
        int secondNumber = 0;

        //loop through the numbers array
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            // How do you know if it is ascending?
            firstNumber = numbers[i];
            secondNumber = numbers[i + 1];

            //ASCENDING SECTION
            if (secondNumber > firstNumber) //block of code for if numbers are ascending (getting larger)
            {
                if (strAscendingOrDescending == "" || strAscendingOrDescending == "ascending") //If it has never been set, or if the last result was ascending, numbers are still ascending
                {
                    strAscendingOrDescending = "ascending"; //Declare numbers to be Ascending
                }
                else
                {
                    strAscendingOrDescending = "neither ascending nor descending";
                }


                if ((secondNumber - firstNumber) == 1)
                {
                    isSequential = true;
                }
                else
                {
                    isSequential = false;
                }
            }
            
            //DESCENDING SECTION
            else if (firstNumber > secondNumber) //block of code for if numbers are descending (getting smaller)
            {
                if (strAscendingOrDescending == "" || strAscendingOrDescending == "descending")
                {
                    strAscendingOrDescending = "descending"; //Declare numbers to be Descending
                }
                else
                {
                    strAscendingOrDescending = "neither ascending nor descending";
                }

                if ((firstNumber - secondNumber) == 1)
                {
                    isSequential = true;
                }
                else
                {
                    isSequential = false;
                }
            }
            else //if the numbers are not ascending or descending then they must be neither
            {
                strAscendingOrDescending = "neither ascending nor descending";
                isSequential = false;
            }


        }
        
        //Use a loop to populate a string to demonstrate what was evaluated
        string strNumbers = "";
        for (int x = 0; x < numbers.Length; x++)
        {
            strNumbers += numbers[x];
            if (x < numbers.Length - 1)
            {
                strNumbers += ",";
            }
        }

        string strIfNotSequential = "";
        if (isSequential == false)
        {
            strIfNotSequential = "not";
        }

        //Write output to the user
        Console.WriteLine($"{strNumbers}");
        Console.WriteLine($"The array was found to be {strIfNotSequential} sequential, and in {strAscendingOrDescending} order.");

        Console.ReadLine();
    }
}