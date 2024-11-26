using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries { get; private set; } = new List<Entry>(); // List of journal entries
    public void AddEntry(Entry _entry) => _entries.Add(_entry); // Adds a new entry to the journal
    public void DisplayEntries() // Displays all journal entries
    {
        foreach (var _entry in _entries)
            Console.WriteLine($"{_entry.Date}: {_entry.Prompt} - {_entry.Response}");
    }
    public void SaveToFile(string _filename) // Saves entries to a specified file
    {
        using var writer = new StreamWriter(_filename);
        foreach (var _entry in _entries)
            writer.WriteLine(_entry.FormatEntry());
    }
    public void LoadFromFile(string _filename) // Loads entries from a specified file
    {
        _entries.Clear();
        foreach (var _line in File.ReadAllLines(_filename))
        {
            var _parts = _line.Split('|');
            if (_parts.Length == 3)
                _entries.Add(new _entry { Date = _parts[0], Prompt = _parts[1], Response = _parts[2] });
        }
    }
}