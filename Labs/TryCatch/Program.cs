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
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("{0} {1}", ex.Message, ex.StackTrace);
        }

        Console.ReadLine();
    }
}