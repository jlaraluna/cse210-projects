using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToShortDateString(),
            _promptText = prompt,
            _entryText = response
        };

        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
{
    using (StreamWriter writer = new StreamWriter(fileName))
    {
        foreach (Entry entry in _entries)
        {
            writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }
    }

    Console.WriteLine($"Journal saved to {fileName}");
}


    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            entry.LoadFromString(line);
            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}
