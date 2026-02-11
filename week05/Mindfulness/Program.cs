using System;
using System.Collections.Generic;

/*
 * W05 Project: Mindfulness Program
 *
 * This program provides three mindfulness activities:
 *   1. Breathing Activity  - Guides the user through paced breathing cycles.
 *   2. Reflection Activity - Prompts the user to reflect on past experiences of strength.
 *   3. Listing Activity    - Asks the user to list positive things in a chosen category.
 *
 * ─── EXCEEDING CORE REQUIREMENTS ──────────────────────────────────────────────
 *
 * 1. NO-REPEAT QUESTION SHUFFLING (ReflectionActivity)
 *    Questions are served from a shuffled queue rather than chosen at random each
 *    time. This guarantees every question is shown before any repeats — the exact
 *    enhancement described in the assignment specification.  When the queue empties
 *    it is refilled and re-shuffled automatically, so the activity can run for any
 *    duration without ever running out of questions.
 *
 * 2. SESSION ACTIVITY LOG
 *    Program.cs maintains a dictionary that counts how many times each activity is
 *    run in the current session.  When the user selects "Quit", a summary screen
 *    displays those counts before exiting, giving the user gentle feedback on their
 *    mindfulness practice for the day.
 *
 * 3. CORRECT MULTI-DIGIT COUNTDOWN ERASE
 *    The base-class ShowCountDown method erases each number by writing exactly as
 *    many backspace/space/backspace characters as digits were printed.  This ensures
 *    numbers 10 and above (e.g., a 30-second breathing countdown) erase cleanly
 *    instead of leaving a stray digit on screen.
 * ──────────────────────────────────────────────────────────────────────────────
 *
 * Author: [Your Name]
 * Date:   [Current Date]
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