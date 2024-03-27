public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {  
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _responses = new List<string>(){};

    public ListingActivity(string name, string description) : base(name, description){}

    public int GetListCount()
    {
        return _count;
    }
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }

    public List<string> GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _responses.Add(Console.ReadLine());
        }

        _count = _responses.Count();
        return _responses;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {GetListCount()} items!");

        DisplayEndingMessage();
    }
}