using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Introduction instructions
                Console.WriteLine("Please make a selection:\nA)dd an item\nC)hange an item\nD)elete\nL)ist all items\nQuit");

                string strUserInput = Console.ReadLine();
                
                switch (strUserInput)
                {
                    case "A":
                        break;
                    
                    case "C":
                        break;
                    
                    case "D":
                        break;
                    
                    case "L":
                        break;
                    
                    case "Q":
                        break;
                    
                    default:
                        break;
                }
                
                Console.ReadLine();
            }
        }
    }
}
