using System;
using System.Collections.Generic;

struct Contact
{
    public String Name;
    public String PhoneNumber;
}

class Program
{
    static void Main()
    {
        // TODO: Create a list of Contact
        var contacts = new List<Contact>();

        // TODO: Add contacts to the list
        contacts.Add(new Contact { Name = "Rebecca", PhoneNumber = "123-4567" });
        contacts.Add(new Contact { Name = "Violet", PhoneNumber = "123-4568" });

        // TODO: Display the Name and PhoneNumber of all the contacts
        foreach (var contact in contacts)
        {
            Console.WriteLine($"New Name: {contact.Name} Age: {contact.PhoneNumber}");
        }

        Console.ReadLine();
    }
}