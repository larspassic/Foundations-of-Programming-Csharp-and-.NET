using System;

// TODO: Define the Contact class to make this compile

class Program
{
    static void Main()
    {
        Contact contact = new Contact();

        contact.FirstName = "FirstName";
        contact.LastName = "LastName";
        contact.Age = 23;

        // GetFullName() returns "FirstName LastName"
        Console.WriteLine("Name: {0} Age: {1}", contact.GetFullName(), contact.Age);
    }
}