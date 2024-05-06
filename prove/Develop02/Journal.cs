using System.IO;
using System.Collections.Generic;



public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}");
                writer.WriteLine($"Prompt: {entry._promptText}");
                writer.WriteLine($"Entry: {entry._entryText}");
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            while (!reader.EndOfStream)
            {
                string date = reader.ReadLine().Split(':')[1].Trim();
                string prompt = reader.ReadLine().Split(':')[1].Trim();
                string entry = reader.ReadLine().Split(':')[1].Trim();
                reader.ReadLine();
                _entries.Add(new Entry { _date = date, _promptText = prompt, _entryText = entry});
            }
        }
    }

}