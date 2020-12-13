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
            var items = new Item[10];
            
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
                        string strDescription = Console.ReadLine();

                        //Prompt user for item quantity
                        Console.Write("Item quantity:");
                        string strQuantity = Console.ReadLine();
                        int intQuantity = int.Parse(strQuantity);

                        //Prompt user for internal cost
                        Console.Write("Internal cost:");
                        string strInternalCost = Console.ReadLine();
                        float floatInternalCost = float.Parse(strInternalCost);

                        //Prompt user for retail price
                        Console.Write("Retail price:");
                        string strRetailPrice = Console.ReadLine();
                        float floatRetailPrice = float.Parse(strRetailPrice);

                        new Item(strDescription, floatRetailPrice, floatInternalCost, intQuantity);

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
