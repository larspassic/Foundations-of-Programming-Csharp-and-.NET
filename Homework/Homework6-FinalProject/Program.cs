using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_FinalProject
{
    
    struct Item
    {
        string ItemNumber;
        string Description;
        float RetailPrice;
        float InternalCost;
        int QuantityOnHand;
        float ItemValue;

        static int nextItemNumber = 100;

        public Item (string description, float retailPrice, float internalCost, int quantityOnHand)
        {
            ItemNumber = "ITEM" + nextItemNumber;
            Description = description;
            RetailPrice = retailPrice;
            InternalCost = internalCost;
            QuantityOnHand = quantityOnHand;
            ItemValue = retailPrice * quantityOnHand;
            nextItemNumber++;
        }
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
                        Console.WriteLine("ADD AN ITEM");
                        
                        //Prompt user for item description
                        Console.Write("Item description:");
                        string strInputDescription = Console.ReadLine();

                        //Prompt user for item quantity

                        //Prompt user for internal cost

                        //Prompt user for retail price

                        //Set item description

                        //Set item quantity

                        //Set internal cost

                        //Set retail price



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
                        Environment.Exit(0);
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
