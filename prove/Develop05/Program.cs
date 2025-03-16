using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        int userChoice = 0;

        Manager manager = new Manager();

        while (userChoice != 6) {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice form the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) {
                // Create Goal

                manager.CreateGoal();
            }
            else if (userChoice == 2) {
                // List Goals

                manager.DisplayGoal();
            }
            else if (userChoice == 3) {
                // Save Goals

                manager.SaveGoals();
            }
            else if (userChoice == 4) {
                // Load Goals

                manager.LoadGoals();
            }
            else if (userChoice == 5) {
                // Record Event

                manager.RecordEvent();
            }
            else if (userChoice == 6) {
                // Quit
            }
            else {
                // Incorrect Input
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}