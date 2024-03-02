using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        int sum = 0;
        int largestNumber = 0;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do 
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
            
        } while (userInput != "0");
        
        // Compute the sum, or total, of the numbers in the list.
        // Find the maximum, or largest, number in the list.
        foreach (int number in numbers)
        {
            sum += number;

            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        // Compute the average of the numbers in the list.
        float average = (float)sum / numbers.Count;
       
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest nuumber is: {largestNumber}");
    }
}
