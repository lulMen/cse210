public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description){}

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
        
    }
}