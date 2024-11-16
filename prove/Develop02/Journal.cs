using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; private set; } = new List<Entry>(); // List of journal entries
    public void AddEntry(Entry entry) => Entries.Add(entry); // Adds a new entry to the journal
    public void DisplayEntries() // Displays all journal entries
    {
        foreach (var entry in Entries)
            Console.WriteLine($"{entry.Date}: {entry.Prompt} - {entry.Response}");
    }
    public void SaveToFile(string filename) // Saves entries to a specified file
    {
        using var writer = new StreamWriter(filename);
        foreach (var entry in Entries)
            writer.WriteLine(entry.FormatEntry());
    }
    public void LoadFromFile(string filename) // Loads entries from a specified file
    {
        Entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
                Entries.Add(new Entry { Date = parts[0], Prompt = parts[1], Response = parts[2] });
        }
    }
}