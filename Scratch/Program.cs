using System;

class Vehicle //Base class or parent class
{
    public string Name;
    public int Passengers;
    public int Speed;

    public Vehicle(string name, int passengers, int speed)
    {
        Name = name;
        Passengers = passengers;
        Speed = speed;
    }
}

class Automobile : Vehicle //The child class - inherits from base class vehicle
{
    public int Windows;

    public Automobile(string name, int passengers, int speed, int windows)
       : base(name, passengers, speed) //Colon base - this indicates which fields are inherited from the parent class
    {
        Windows = windows;
    }
}

class Motorcycle : Vehicle //Another child class - inherits from base class vehicle
{
    public int Seats;

    public Motorcycle(string name, int passengers, int speed, int seats)
        : base(name, passengers, speed)
    {
        Seats = seats;
    }
}


class Program //End user or client that makes use of the vehicle family
{
    // Notice that this take a base class Vehicle object
    // and not a specific child class
    public static void PrintInfo(Vehicle v)
    {
        Console.WriteLine("Name is {0}", v.Name);
        Console.WriteLine("Passengers is {0}", v.Passengers);
    }

    static void Main()
    {
        var myVehicle = new Vehicle("My Vehicle", 0, 100);
        var myHondaCivic = new Automobile("Honda Civic", 2, 120, 2);
        var myHarley = new Motorcycle("Harley Low Rider", 1, 100, 1);

        PrintInfo(myVehicle);
        PrintInfo(myHondaCivic);
        PrintInfo(myHarley);
    }
}