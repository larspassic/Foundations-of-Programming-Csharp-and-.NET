// File: Struct.cs
using System;

struct Person
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        // Using var is shorthand for Person[ ]
        var persons = new Person[2];

        persons[0].Name = "Steve";
        persons[0].Age = 31;

        persons[1].Name = "Lisa";
        persons[1].Age = 28;

        foreach (var person in persons)
        {
            Console.WriteLine("{0} is {1} years old.", person.Name, person.Age);
        }
        Console.ReadLine();
    }
}