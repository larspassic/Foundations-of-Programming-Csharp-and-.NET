// Factorial.cs
using System;

class Factorial
    {
    static void Main()
        {
        long nFactorial = 1;
        long nComputeTo = 200; // Calc 200 factorial
       try
        {
            checked
            {
                for (long nCurDigit = 1; nCurDigit <= nComputeTo; nCurDigit++)
                {
                    nFactorial = nFactorial * nCurDigit;
                }
            }
        }
        catch (OverflowException e)
        {
            //1. What happened? 
            //2. where did this happen?
            Console.WriteLine($"Computing {nComputeTo}! caused an overflow {e.StackTrace}");
            return;
        }
        
        
        Console.WriteLine("{0}! is {1}", nComputeTo, nFactorial);
        Console.ReadLine();
        }
    }