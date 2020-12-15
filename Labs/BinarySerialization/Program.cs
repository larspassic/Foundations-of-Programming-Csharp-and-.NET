// File: FileStruct.cs
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
struct Item
{
    public int ItemNumber;
    public string Description;
    public double Amount;
}

class FileStructMain
{
    static void Main()
    {
        // A. Create the array of structs
        Item[] items = new Item[5];

        items[0].ItemNumber = 1;
        items[0].Description = "apple";
        items[0].Amount = .25;

        items[1].ItemNumber = 3;
        items[1].Description = "cherries";
        items[1].Amount = .15;

        items[2].ItemNumber = 8;
        items[2].Description = "pears";
        items[2].Amount = .10;

        items[3].ItemNumber = 5;
        items[3].Description = "peaches";
        items[3].Amount = .12;

        items[4].ItemNumber = 6;
        items[4].Description = "pineapple";
        items[4].Amount = 1.25;

        // B. Create the binary file
        FileStream stream = File.Create("test.bin");

        // C. Create a binary formatter
        BinaryFormatter formatter = new BinaryFormatter();

        // D. Save the data
        foreach (Item item in items)
        {
            formatter.Serialize(stream, item);
        }

        // E. Close the stream
        stream.Close();

        // F. Open the binary file
        stream = File.Open("test.bin", FileMode.Open);

        // G. Create a binary formatter
        formatter = new BinaryFormatter();

        // H. Read from the stream
        while (true)
        {
            // I. Keep reading until you hit an exception
            try
            {
                Item item = (Item)formatter.Deserialize(stream);
                Console.WriteLine(item.Description);
            }
            catch (SerializationException ex)
            {
                string str = ex.Message;
                break;
            }
        }

        // J. Close the stream
        stream.Close();

        Console.ReadLine();
    }
}