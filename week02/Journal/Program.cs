using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your entry: ");
                    string text = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry(date, prompt, text);
                    theJournal.AddEntry(newEntry);

                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    // Display all entries
                    theJournal.DisplayAll();
                    break;

                case "3":
                    // Save journal to file
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved!\n");
                    break;

                case "4":
                    // Load journal from file
                    Console.WriteLine("Load feature not implemented yet.");
                    // You can implement parsing later
                    break;

                case "5":
                    // Quit
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }
        }
    }
}
