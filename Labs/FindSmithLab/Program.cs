// File: Find a typed last name Smith
using System;

class Lastname
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a person's full name:");
            string str = Console.ReadLine();

            str = str.ToUpper();

            if (str.EndsWith(" SMITH"))
            {
                Console.WriteLine("Smith was found as the last name.");
            }
            else
            {
                Console.WriteLine("Smith was not found as the last name.");

            }

            //Console.ReadLine();
        }
    }
}