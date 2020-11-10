using System;

// TODO: Define the Contact class to make this compile

class Contact
{
    public string FirstName;
    public string LastName;
    public int Age;

    public String GetFullName()
    {
        return ($"{FirstName} {LastName}");
    }
}

class Program
{
    static void Main()
    {
        Contact contact = new Contact();

        contact.FirstName = "Lars";
        contact.LastName = "Passic";
        contact.Age = 32;

        // GetFullName() returns "FirstName LastName"
        Console.WriteLine("Name: {0} Age: {1}", contact.GetFullName(), contact.Age);
        Console.ReadLine();
    }
}