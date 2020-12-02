// File: Point2.cs
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

    //This process is called "Data Hiding"
    public int GetX()
    {
        return X;
    }

    public int GetY()
    {
        return Y;
    }
}

class Program
{
    static void Main()
    {
        Point pt = new Point(10, 20);

        Console.WriteLine("{0},{1}", pt.GetX(), pt.GetY());
    }
}