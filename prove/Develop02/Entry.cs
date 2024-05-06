public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_promptText}\nEntry: {_entryText}\n");   
    }
}