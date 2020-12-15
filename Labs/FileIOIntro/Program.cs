// File: FileText.cs
using System;
using System.IO;

class FileMain
{
    static void Main()
    {
        // A. Create a text file
        // The file will be created in the same directory as the executable
        // You can specify a file path but you may have security issues @"C:\test.txt"
        StreamWriter streamWriter = File.CreateText("test.txt");

        // AutoFlush will write to the file after every write.
        // If AutoFlush is false it will cache the data in memory
        // streamWriter.AutoFlush = true;

        // B. Write text to the file
        streamWriter.WriteLine("apple");
        streamWriter.WriteLine("berry");
        streamWriter.WriteLine("cherry");
        streamWriter.WriteLine("date");
        streamWriter.WriteLine();
        streamWriter.WriteLine("elderberry");

        // C. Close the writer
        streamWriter.Close();

        // D. Reopen the text file
        StreamReader streamReader = File.OpenText("test.txt");

        // E. Read the text file
        string str;

        while ((str = streamReader.ReadLine()) != null)
        {
            Console.WriteLine(str);
        }

        // F. Close the reader
        streamReader.Close();

        Console.ReadLine();
    }
}