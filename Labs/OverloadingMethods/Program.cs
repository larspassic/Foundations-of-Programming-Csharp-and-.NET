using System;

class Point
{
    private int x; //this is a field
    private int y; //fields are part of the class

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Point(double x, double y)
    {
        this.x = (int)x;
        this.y = (int)y;
    }

    public void Add(int x, int y)
    {
        this.x += x;
        this.y += y;
    }

    public void Add(double x, double y)
    {
        this.x += (int)x;
        this.y += (int)y;
    }

    public void Add(Point point)
    {
        this.x += point.x;
        this.y += point.y;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }
}

class Program
{
    static void Main()
    {
        // TODO: Define an overloaded constructor
        // that takes two doubles and casts them to integers

        var myPoint = new Point(10.0, 20.0);

        myPoint.Add(11, 22);

        Console.WriteLine("X={0} Y={1}", myPoint.GetX(), myPoint.GetY());

        var secondPoint = new Point(1000, 2000);

        // TODO: Add overloaded Add method that takes a Point
        myPoint.Add(secondPoint);

        Console.WriteLine("X={0} Y={1}", myPoint.GetX(), myPoint.GetY());

        Console.ReadLine();
    }
}