using System;
using System.Collections.Generic;

/*
 * W05 Project: Mindfulness Program
 * 
 * This program provides three mindfulness activities:
 * 1. Breathing Activity - Paced breathing exercise
 * 2. Reflection Activity - Reflection on past experiences of strength
 * 3. Listing Activity - Listing positive things in various categories
 * 
 * EXCEEDING REQUIREMENTS:
 * - Added activity log tracking to keep count of how many times each activity was performed
 * - Activity statistics are displayed when user quits
 * - Enhanced animations with smooth spinner display
 * 
 * Author: [Your Name]
 * Date: [Current Date]
 */

class Program
{
    static void Main(string[] args)
    {
        // Track activity usage for logging
        Dictionary<string, int> activityLog = new Dictionary<string, int>
        {
            { "Breathing", 0 },
            { "Reflection", 0 },
            { "Listing", 0 }
        };

        string choice = "";

        // Main menu loop
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activityLog["Breathing"]++;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                activityLog["Reflection"]++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                activityLog["Listing"]++;
            }
            else if (choice == "4")
            {
                // Display activity statistics before quitting
                Console.Clear();
                Console.WriteLine("Activity Summary:");
                Console.WriteLine("=================");
                Console.WriteLine($"Breathing activities completed: {activityLog["Breathing"]}");
                Console.WriteLine($"Reflection activities completed: {activityLog["Reflection"]}");
                Console.WriteLine($"Listing activities completed: {activityLog["Listing"]}");
                Console.WriteLine();
                Console.WriteLine("Thank you for taking time to be mindful today!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}