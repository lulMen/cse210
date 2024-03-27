using System.Runtime.InteropServices;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {       
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {        
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _selectedQuestions = new List<string>(){};

    public ReflectingActivity(string name, string description) : base(name, description){}

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);

        while (_selectedQuestions.Contains(_questions[i]))
        {
            i = random.Next(_questions.Count);
        }

        _selectedQuestions.Add(_questions[i]);
        return _questions[i];     
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");   
    }

    public void DisplayQuestion()
    {
        Console.Write($"\n> {GetRandomQuestion()} ");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int i = 0;

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);

            if (i >= _questions.Count())
            {
                break;
            }
        }

        DisplayEndingMessage();
    }
}