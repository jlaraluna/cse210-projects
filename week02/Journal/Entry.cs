using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }

    public string GetEntryAsString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public void LoadFromString(string line)
    {
        string[] parts = line.Split('|');
        _date = parts[0];
        _promptText = parts[1];
        _entryText = parts[2];
    }
}
