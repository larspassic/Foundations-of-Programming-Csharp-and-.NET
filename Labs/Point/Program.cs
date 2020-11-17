// File: Point.cs
using System;

class Point
{
    public int X;
    public int Y;

    // public Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class TestPointClass
{
    static void Main()
    {
        Point pt = new Point(10, 20);
        //pt points to null
        //initializes all fields to zero to start with (regardless)
        //the keyword new creates a reference to where the object is going to refer to
        //call on the constructor if any - in this case we have a constructor
        //pass in the parameters via the constructor if any
        //create the object : pt points to designated class (allows you to access the class content)

        Console.WriteLine("{0},{1}", pt.X, pt.Y);
    }
}