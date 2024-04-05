public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){}

    public void Start()
    {
        bool isRunning = true;

        while (isRunning)
        {
            DisplayPlayerInfo();
            List<string> mainOptions = new List<string>
            {
                "1. Create New Goal",
                "2. List Goals",
                "3. Save Goals",
                "4. Load Goals",
                "5. Record Event",
                "6. Quit"
            };

            Console.WriteLine("Menu Options:");
            foreach (string option in mainOptions)
            {
                Console.WriteLine($"  {option}");
            }

            Console.Write("Select a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                CreateGoal();
            } else if (menuChoice == 2)
            {
                ListGoalDetails();
            } else if (menuChoice == 3)
            {
                SaveGoals();
            } else if (menuChoice == 4)
            {
                LoadGoals();
            } else if (menuChoice == 5)
            {
                RecordEvent();
            } else if (menuChoice == 6)
            {
                isRunning = false;
            }
        }  
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        string name;
        string description;
        string score;

        List<string> goalOptions = new List<string>
        {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };

        Console.WriteLine("The types of Goals are:");
        foreach (string option in goalOptions)
        {
            Console.WriteLine($"  {option}");
        }

        Console.Write("Which type of goal would you like to create? ");
        int goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice == 1)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            score = Console.ReadLine();
            SimpleGoal newGoal = new SimpleGoal(name, description, score, goalChoice);
            _goals.Add(newGoal);

        } else if (goalChoice == 2)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            score = Console.ReadLine();
            EternalGoal newGoal = new EternalGoal(name, description, score, goalChoice);
            _goals.Add(newGoal);

        } else if (goalChoice == 3)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            score = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(name, description, score, goalChoice, target, bonus);
            _goals.Add(newGoal);

        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");

        int goal = int.Parse(Console.ReadLine());
        int goalPosition = goal - 1;
        _goals[goalPosition].RecordEvent();

        int points = int.Parse(_goals[goalPosition].GetPoints());
        _score += points;

        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points.\n");
    }

     public void SaveGoals()
     {
        string fileName = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"score,{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
     }  

     public void LoadGoals()
     {
        string fileName = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts[0] == "score")
            {
                _score = int.Parse(parts[1]);
            } else if (parts[0] == "1")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], parts[3], int.Parse(parts[0]));
                goal.SetIsComplete(bool.Parse(parts[4]));
                _goals.Add(goal);
            } else if (parts[0] == "2")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], parts[3], int.Parse(parts[0]));
                _goals.Add(goal);
            } else if (parts[0] == "3")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[0]), int.Parse(parts[6]), int.Parse(parts[7]));
                goal.SetAmountCompleted(int.Parse(parts[5]));
                _goals.Add(goal);
            }
        }
     }   
}