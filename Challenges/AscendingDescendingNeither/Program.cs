using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 0,1,2,2,3 };

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
            if (secondNumber >= firstNumber) //block of code for if numbers are ascending (getting larger)
            {
                if (strAscendingOrDescending == "" || strAscendingOrDescending == "ascending") //If it has never been set, or if the last result was ascending, numbers are still ascending
                {
                    strAscendingOrDescending = "ascending"; //Declare numbers to be Ascending
                }
                else
                {
                    strAscendingOrDescending = "neither ascending nor descending";
                }

                if (i > 0 && isSequential == false) //if the loop has run once then we know it wasn't sequential before so it can't be sequential now
                {
                    isSequential = false;
                }
                else if ((secondNumber - firstNumber) == 1)
                {
                    isSequential = true;
                }
                else
                {
                    isSequential = false;
                }
            }
            
            //DESCENDING SECTION
            else if (firstNumber >= secondNumber) //block of code for if numbers are descending (getting smaller)
            {
                if (strAscendingOrDescending == "" || strAscendingOrDescending == "descending")
                {
                    strAscendingOrDescending = "descending"; //Declare numbers to be Descending
                }
                else
                {
                    strAscendingOrDescending = "neither ascending nor descending";
                }

                if (i > 0 && isSequential == false) //if the loop has run once then we know it wasn't sequential before so it can't be sequential now
                {
                    isSequential = false;
                }
                else if ((firstNumber - secondNumber) == 1)
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
            strIfNotSequential = " not";
        }

        //Write output to the user
        Console.WriteLine($"{strNumbers}");
        Console.WriteLine($"The array was found to be{strIfNotSequential} sequential, and in {strAscendingOrDescending} order.");

        Console.ReadLine();
    }
}