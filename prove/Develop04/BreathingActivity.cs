public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "\n\nWelcome to the Breathing Activity.\n\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n\n";
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            remainingTime -= 4;
            
            if (remainingTime <= 0) break;
            
            Console.Write("Now Breathe out...");
            ShowCountDown(6);
            remainingTime -= 6;
        }
        
        DisplayEndingMessage();
    }
}
