using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    string fileName;

    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date} {entry._prompt} {entry._input}");
        }
    }
    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.Write();
        _entries.Add(entry);
    }
    public void Save()
    {
        Console.Write("What is the file name? ");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} {entry._prompt} {entry._input}");
            }
    }
    public void Load()
    {
        // Read each line of the file into a string array. Each element
        // of the array is one line of the file.
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
}