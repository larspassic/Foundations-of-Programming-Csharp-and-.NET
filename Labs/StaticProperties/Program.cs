using System;

struct Contact
{
    // TODO: Copy your code from Static Fields lab here
    public int ContactId;
    public String Name;
    public String PhoneNumber;

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        ContactId = nextContactId;
        nextContactId++;
    }

    // TODO: Create static nextContactId
    public static int nextContactId = 100;

    // TODO: Add static property CurrentNextContactId
    public static int CurrentNextContactId
    {
        get
        {
            return nextContactId;
        }
    }

}

class Program
{
    static void Main()
    {
        Console.WriteLine("CurrentNextContactId = {0} should be 100", Contact.CurrentNextContactId);

        var contact = new Contact("mike", "111-222-3333");

        // TODO: Why does is not compile? What does the compiler say?
        Console.WriteLine("CurrentNextContactId = {0} should be 101", Contact.CurrentNextContactId); //this doesn't compile because it is from an instance called contact

        var contact2 = new Contact("steve", "222-333-4444");

        // TODO: Why does is not compile? What does the compiler say?
        Console.WriteLine("CurrentNextContactId = {0} should be 102", Contact.CurrentNextContactId); //this doesn't compile because it is from an instance called contact

        Console.ReadLine();
    }
}