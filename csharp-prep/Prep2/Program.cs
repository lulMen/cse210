using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;

        Console.Write("What is the grade percentage? ");
        string userInput = Console.ReadLine();
        int grade =  int.Parse(userInput);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >=70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"You received a {letter}. Congratulations! You've passed.");
        }
        else
        {
            Console.WriteLine($"You received a {letter}. You've failed. Give it another try.");
        }
    }
}