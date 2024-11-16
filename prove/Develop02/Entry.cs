using System;

/// <summary>
/// Represents a journal entry with a prompt, response, and a date.
/// </summary>
public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string FormatEntry() => $"{Date}|{Prompt}|{Response}";
}