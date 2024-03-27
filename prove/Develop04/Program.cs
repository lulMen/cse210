using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menuOptions = new List<string>()
        {
            "  1. Start Breathing Activity", "  2. Start Reflecting Activity", "  3. Start Listing Activity", "  4. Quit"
        };
        string breathingActivityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string reflectingActivityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listingActivityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        bool programIsRunning = true;


        while (programIsRunning)
        {
            Console.WriteLine("Menu Options:");
            foreach(string option in menuOptions)
            {
                Console.WriteLine(option);
            }
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", breathingActivityDescription);
                breathingActivity.Run();
            } else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", reflectingActivityDescription);
                reflectingActivity.Run();
            } else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activitiy", listingActivityDescription);
                listingActivity.Run();
            } else if (choice == 4)
            {
                programIsRunning = false;
            }
                else {
                Console.WriteLine("Try again.");
            }
            
        }
    }
}