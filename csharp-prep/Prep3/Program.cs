using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess;

        do 
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (number != guess);
        
    }
}