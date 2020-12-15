// Factorial.cs
using System;

class Factorial
{
    static void Main()
    {
        long nFactorial = 1;
        long nComputeTo = 200; // Calc 200 factorial

        for (long nCurDigit = 1; nCurDigit <= nComputeTo; nCurDigit++)
        {
            nFactorial = nFactorial * nCurDigit;
        }

        Console.WriteLine("{0}! is {1}", nComputeTo, nFactorial);
        Console.ReadLine();
    }
}