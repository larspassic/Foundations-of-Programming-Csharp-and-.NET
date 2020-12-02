using System;

class Point
{
    private int X;
    private int Y;

    // public Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void IncrementXBy(int x)
    {
        X = X + x;
    }
    public void IncrementXBy(long x)
    {
        X = X + (int)x;
    }
    public void IncrementXBy(double x)
    {
        X = X + (int)x;
    }
}

class Program
{
    static void Main()
    {
        
        
        var pt = new Point(10, 20);
        pt.
        // Call int version because
        // 2 is an integer
        pt.IncrementXBy(2);

        // Call long version because
        // 2 is cast as a long integer
        pt.IncrementXBy((long)2);

        // Call double version because
        // 3.4 is a double
        pt.IncrementXBy(3.4);

        Console.ReadLine();
    }
}