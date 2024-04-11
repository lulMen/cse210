using System;

class Program
{
    static void Main(string[] args)
    {
        Data data = new Data();
        bool isRunning = true;

        Lecture lecture = new(data.titles[0],data.descriptions[0],data.dates[0],data.times[0],data.addresses[0],data.speaker,data.capacity);
        Reception reception = new(data.titles[1],data.descriptions[1],data.dates[1],data.times[1],data.addresses[1],data.email);
        Gathering gathering = new(data.titles[2],data.descriptions[2],data.dates[2],data.times[2],data.addresses[2],data.weather);

        while (isRunning)
        {
            Console.WriteLine("AVAILABLE EVENTS:");
            Console.WriteLine("  1. Lecture Event\n  2. Reception Event\n  3. Social Gathering Event\n  4. Quit");
            Console.Write("Please make a selection (1-4): ");
            string selection = Console.ReadLine();

            if (int.TryParse(selection, out int id))
            {
                if (id == 4)
                {
                    isRunning = false;
                } else if (id == 3)
                {
                    Console.WriteLine($"\n  STANDARD DESCRIPTION");
                    gathering.DisplayStandard();
                    Console.WriteLine($"  SHORT DESCRIPTION");
                    gathering.DisplayShort();
                    Console.WriteLine($"  FULL DESCRIPTION");
                    gathering.DisplayFull();
                } else if (id == 2)
                {
                    Console.WriteLine($"\n  STANDARD DESCRIPTION");
                    reception.DisplayStandard();
                    Console.WriteLine($"  SHORT DESCRIPTION");
                    reception.DisplayShort();
                    Console.WriteLine($"  FULL DESCRIPTION");
                    reception.DisplayFull();
                } else if (id == 1)
                {
                    Console.WriteLine($"\n  STANDARD DESCRIPTION");
                    lecture.DisplayStandard();
                    Console.WriteLine($"  SHORT DESCRIPTION");
                    lecture.DisplayShort();
                    Console.WriteLine($"  FULL DESCRIPTION");
                    lecture.DisplayFull();
                } else {Console.WriteLine("Try again.\n");}
            } else {Console.WriteLine("Try again.\n");}
        }
    }
}