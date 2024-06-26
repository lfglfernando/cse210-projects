public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "\nWelcome to the Listing Activity\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\n";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        ShowSpinner(3);

        Console.WriteLine("Start listing items:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> items = new List<string>();
        
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");

        DisplayEndingMessage();
    }
}
