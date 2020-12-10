using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_FinalProject
{
    
    struct Item
    {
        string itemNumber;
        string description;
        float externalCost;
        float internalCost;
        int quantityOnHand;
        float itemValue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Introduction instructions
                Console.WriteLine("Please make a selection:\nA)dd an item\nC)hange an item\nD)elete\nL)ist all items\nQuit");

                //Take input from the user
                string strUserInput = Console.ReadLine();
                
                //Main switch statement
                switch (strUserInput)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("Case A");
                        break;
                    
                    case "C":
                    case "c":
                        Console.WriteLine("Case C");
                        break;
                    
                    case "D":
                    case "d":
                        Console.WriteLine("Case D");
                        break;
                    
                    case "L":
                    case "l":
                        Console.WriteLine("Case L");
                        break;
                    
                    case "Q":
                    case "q":
                        Console.WriteLine("Case Q");
                        break;
                    
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                
                Console.ReadLine();
            }
        }
    }
}
