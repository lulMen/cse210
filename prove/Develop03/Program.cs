using System;

class Program
{
    static void Main(string[] args)
    {
        string currentBook = "Proverbs";
        int currentChapter = 3;
        int currentVerse = 5;
        int currentEndVerse = 6;
        string currentText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        int wordsToHide = 4;
        string input;
        bool programRunning = true;

        Reference currentReference = new Reference(currentBook, currentChapter, currentVerse, currentEndVerse);
        Scripture currentScripture = new Scripture(currentReference, currentText);

        do
        {
            Console.WriteLine(currentScripture.GetDisplayText() + "\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input == "quit")
            {
                programRunning = false;
            } else if (!currentScripture.IsCompletelyHidden())
            {
                currentScripture.HideRandomWords(wordsToHide);
                Console.Clear();
            } else {
                programRunning = false;
            }
        } while (programRunning);
    }
}