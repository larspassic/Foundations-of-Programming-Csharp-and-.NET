using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_FinalProject
{

    struct Item
    {
        public int ItemNumber;
        public string Description;
        public int QuantityOnHand;
        public float InternalCost;
        public float RetailPrice;
        public float ItemValue;

        static int nextItemNumber = 100;

        public Item(string description, float retailPrice, float internalCost, int quantityOnHand)
        {
            ItemNumber = nextItemNumber;
            Description = description;
            QuantityOnHand = quantityOnHand;
            RetailPrice = retailPrice;
            InternalCost = internalCost;

            ItemValue = retailPrice * quantityOnHand;
            nextItemNumber++;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var numberOfItems = 0;
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

                        items[numberOfItems] = new Item(strDescription, floatRetailPrice, floatInternalCost, intQuantity);

                        numberOfItems++;
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
                        Console.WriteLine("LIST ITEMS");
                        if (numberOfItems == 0)
                        {
                            Console.WriteLine("No items");
                        }
                        else
                        {
                            Console.WriteLine("Item# Description Quantity Cost Price Value");
                            Console.WriteLine("----- ----------- -------- ---- ----- -----");

                            for (int loopInt = 0; loopInt < numberOfItems; loopInt++)
                            {
                                Console.WriteLine($"{items[loopInt].ItemNumber},{items[loopInt].Description},{items[loopInt].QuantityOnHand},{items[loopInt].InternalCost},{items[loopInt].RetailPrice},{items[loopInt].ItemValue}");
                            }
                        }


                        break;

                    case "Q":
                    case "q":
                        //Console.WriteLine("Case Q");
                        //Environment.Exit(0);
                        return;

                    default:
                        Console.WriteLine("Default case");

                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
