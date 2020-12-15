using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 1;

            x = x / (x - 1);
        }


        catch (DivideByZeroException divex) //More specific exception type. If this is below Exception, it will never be used.
        {
            Console.WriteLine("{0} {1}", divex.Message, divex.StackTrace);
        }

        catch (OverflowException ovex) //Another specific exception type. If this is below Exception, it will never be used.
        {
            Console.WriteLine("{0} {1}", ovex.Message, ovex.StackTrace);
        }

        catch (Exception ex) //Most generic exception type. This belongs at the bottom.
        {
            Console.WriteLine("{0} {1}", ex.Message, ex.StackTrace);
        }

        Console.ReadLine();
    }
}