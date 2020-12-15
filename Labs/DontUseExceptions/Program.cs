using System;

class Test
{
    static void TestParseWithExceptions()
    {
        try
        {
            double d;
            d = double.Parse("wrong");
        }
        catch
        {
            // Ignore exception
        }
    }

    static void TestWithTryParse()
    {
        double d;
        bool result = double.TryParse("wrong", out d);
    }

    static void Main()
    {
        int start;
        int stop;

        start = Environment.TickCount;
        for (int i = 0; i < 100; i++)
        {
            TestParseWithExceptions();
        }
        stop = Environment.TickCount;
        Console.WriteLine("      100 iterations of Parse   : {0,5} ticks", stop - start);

        start = Environment.TickCount;
        for (int i = 0; i < 8000000; i++)
        {
            TestWithTryParse();
        }
        stop = Environment.TickCount;
        Console.WriteLine("8,000,000 iterations of TryParse: {0,5} ticks", stop - start);

        Console.ReadLine();
    }
}