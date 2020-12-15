using System;

class Factorial
{
    static void Main()
    {
        long nFactorial = 1;
        long nComputeTo = 200;
        bool fSuccess = false;
        long nCurDigit = 1;

        try
        {
            long x = 5 / (nFactorial - 1);
            checked
            {
                for (; nCurDigit <= nComputeTo; nCurDigit++)
                {
                    nFactorial *= nCurDigit;
                }
            }

            fSuccess = true;
        }
        
        catch (DivideByZeroException e)
        {
            Console.WriteLine("{0} {1}", e.Message, e.StackTrace);
        }
        
        catch (Exception e)
        {
            Console.WriteLine("Computing {0}! caused an overflow {1}",
                nComputeTo, e.StackTrace);
        }
        
        finally //Last minute cleanup or finalizing statement
        {
            if (fSuccess)
            {
                Console.WriteLine("{0}! is {1}", nComputeTo, nFactorial);
            }
        }
    }
}