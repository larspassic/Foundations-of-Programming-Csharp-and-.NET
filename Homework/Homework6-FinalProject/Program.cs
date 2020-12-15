using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public static void ListItems(int numberOfItems, Item[] items)
        {
            Console.WriteLine("##############\n# LIST ITEMS #\n##############");

            if (numberOfItems == 0) //Check if the database is empty
            {
                Console.WriteLine("No items were found. Returning to main menu.\n");
            }
            else //If the database isn't empty then loop through everything in to a table
            {
                Console.WriteLine("Item# Description Quantity CostPerItem PricePerItem TotalValue");
                Console.WriteLine("----- ----------- -------- ----------- ------------ ----------");

                for (int loopInt = 0; loopInt < numberOfItems; loopInt++)
                {
                    Console.WriteLine($"{items[loopInt].ItemNumber,-5} {items[loopInt].Description,-11} {items[loopInt].QuantityOnHand,-8} {items[loopInt].InternalCost,-11:C} {items[loopInt].RetailPrice,-12:C} {items[loopInt].ItemValue,-10:C}");
                }

                Console.WriteLine();
            }
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
                Console.WriteLine("#############\n# MAIN MENU #\n#############\nA)dd an item\nC)hange an item\nD)elete\nL)ist all items\nQ)uit\n");
                Console.Write("User input:");

                //Take input from the user
                string strUserInput = Console.ReadLine();
                Console.WriteLine();

                //Main switch statement
                switch (strUserInput)
                {
                    case "A":
                    case "a":
                        
                        Console.WriteLine("###############\n# ADD AN ITEM #\n###############");

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

                        numberOfItems++; //iterate the total amount of items in the database
                        Console.WriteLine();
                        break;

                    case "C":
                    case "c":
                        Console.WriteLine("##################\n# CHANGE AN ITEM #\n##################");
                        
                        //First list the items out
                        Item.ListItems(numberOfItems, items);

                        //Prompt the user for input
                        Console.WriteLine("Which item do you want to change? Please enter the item number.");

                        //Accept input from user
                        string strItemToChange = Console.ReadLine();
                        int intItemToChange = int.Parse(strItemToChange);

                        //Loop to find the item's array index
                        int itemFoundIndex = 0;
                        bool itemFoundBool = false;
                        for (int index = 0; index < numberOfItems; index++)
                        {
                            if (items[index].ItemNumber == intItemToChange)
                            {
                                itemFoundIndex = index;
                                itemFoundBool = true;
                            }
                        }
                        if (itemFoundBool == true)
                        {
                            //Prompt user for item description
                            Console.Write("Updated Item description:");
                            strDescription = Console.ReadLine();

                            //Prompt user for item quantity
                            Console.Write("Updated Item quantity:");
                            strQuantity = Console.ReadLine();
                            intQuantity = int.Parse(strQuantity);

                            //Prompt user for internal cost
                            Console.Write("Updated Internal cost:");
                            strInternalCost = Console.ReadLine();
                            floatInternalCost = float.Parse(strInternalCost);

                            //Prompt user for retail price
                            Console.Write("Updated Retail price:");
                            strRetailPrice = Console.ReadLine();
                            floatRetailPrice = float.Parse(strRetailPrice);

                            //Use the index to write over the item
                            items[itemFoundIndex] = new Item(strDescription, floatRetailPrice, floatInternalCost, intQuantity);

                            //Inform the user of the change
                            Console.WriteLine("Item updated successfully.");
                            Console.WriteLine();
                            Item.ListItems(numberOfItems, items);
                            
                        }
                        if (itemFoundBool == false)
                        {
                            Console.WriteLine("Item was not found, returning to main menu.");
                            break;
                        }

                        Console.WriteLine(); //Extra line at the end
                        break;

                    case "D":
                    case "d":
                        Console.WriteLine("##################\n# DELETE AN ITEM #\n##################");
                        
                        //First list the items out
                        Item.ListItems(numberOfItems, items);

                        //Prompt user for input
                        //Prompt the user for input
                        Console.WriteLine("Which item do you want to delete? Please enter the item number.");

                        //Accept input from user
                        string strItemToDelete = Console.ReadLine();
                        int intItemToDelete = int.Parse(strItemToDelete);

                        //Loop to find the item's array index
                        itemFoundIndex = 0;
                        itemFoundBool = false;
                        for (int index = 0; index < numberOfItems; index++)
                        {
                            if (items[index].ItemNumber == intItemToDelete)
                            {
                                itemFoundIndex = index;
                                itemFoundBool = true;
                            }
                        }

                        for (int index = itemFoundIndex; index < numberOfItems; index++)
                        {
                            items[index] = items[index + 1];
                        }
                        //Inform the user of the change
                        Console.WriteLine("Item deleted successfully.");
                        Console.WriteLine();
                        Item.ListItems(numberOfItems, items);

                        Console.WriteLine(); //Extra line at the end
                        break;

                    case "L":
                    case "l":
                        //Use the ListItems method to list out the items
                        Item.ListItems(numberOfItems, items);

                        break;

                    case "Q":
                    case "q":
                        Console.WriteLine("Are you sure you want to quit? WARNING: All items in the in-memory database application will be  lost. (Y/N)\n");
                        Console.Write("User input:");
                        string strQuit = Console.ReadLine(); //Ask user for input
                        strQuit = strQuit.ToLower(); //Make it lowercase to simplify the next decision
                        
                        if (strQuit == "y") //Only quit if we have a Y or y positive confirmation
                        {
                            return;
                        }
                        else //Otherwise return to main menu
                        {
                            Console.WriteLine("\nReturning to main menu.\n");
                        }
                        break;


                    default:
                        Console.WriteLine("That was not a valid input. Please try again.\n");

                        break;
                }
            }
        }
    }
}
